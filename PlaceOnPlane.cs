using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;

using UnityEngine.XR.ARFoundation;

public class Plane : MonoBehaviour
{
    private ARSessionOrigin sessionOrigin;
    ARRaycastManager raycastManager;
    private List<ARRaycastHit> hits;

    public GameObject model;
    public GameObject canvas;

    void Start()

    {
        sessionOrigin = GetComponent<ARSessionOrigin>();
        raycastManager = GetComponent<ARRaycastManager>();
        hits = new List<ARRaycastHit>();

        model.SetActive(false);
        canvas.SetActive(false);
    }


    void Update()
    {
        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);

        if (IsPointerOverUIObject(touch.position))
            return;

        if (raycastManager.Raycast(touch.position, hits))
        {
            Pose pose = hits[0].pose;
            
            Instantiate(model, pose.position, pose.rotation);
            // if (!model.activeInHierarchy)
            // {
            //     model.SetActive(true);
            //     model.transform.position = pose.position;
            //     model.transform.rotation = pose.rotation;


            //     //canvas.SetActive(true);
            // }
            // else
            // {
            //     model.transform.position = pose.position;
            // }
        }
    }

    bool IsPointerOverUIObject(Vector2 pos)
    {
        if (EventSystem.current == null)
            return false;
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(pos.x, pos.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
}