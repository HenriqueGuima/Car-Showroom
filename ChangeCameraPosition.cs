﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraPosition : MonoBehaviour
{
	
	public Transform cameraTarget1;
	public Transform cameraTarget2;
	public Transform cameraTarget3;
    public float sSpeed = 10.0f;
    public Vector3 dist;
    public Transform lookTarget;
	
	private int currenttarget;
	private Transform cameraTarget;

    void Start()
    {
        currenttarget = 1;
		SetCameraTarget(currenttarget);
    }


    void Update()
    {
        
    }
	
	void FixedUpdate() {
        Vector3 dPos = cameraTarget.position + dist;
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
    }
	
	public void SetCameraTarget(int num){
		switch(num){
			case 1 :
				cameraTarget = cameraTarget1.transform;
				break;
			case 2 :
				cameraTarget = cameraTarget2.transform;
				break;
			case 3 :
				cameraTarget = cameraTarget3.transform;
				break;
		}
	}
	
	public void SwitchCamera(){
		if(currenttarget < 3)
			currenttarget++;
		else 
			currenttarget = 1;
		SetCameraTarget(currenttarget);
	}
}
