using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeColor : MonoBehaviour
{

    public MeshRenderer meshModel;
    
    public void Change(){
        meshModel.material.color = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;
    }
}
