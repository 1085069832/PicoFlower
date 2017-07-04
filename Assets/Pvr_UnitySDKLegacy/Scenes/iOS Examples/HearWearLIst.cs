﻿using UnityEngine;
using System.Collections;

public class HearWearLIst : MonoBehaviour {

	private bool mShow = false;
	public GameObject root;
	void Awake(){
		
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void Show()
	{
		mShow = !mShow;
		this.gameObject.SetActive ( mShow );
		root.transform.Find ("BLEListCanvas").gameObject.SetActive (false);
		root.transform.Find("Canvas").gameObject.SetActive(true);
		root.transform.Find ("TTT").gameObject.SetActive (false);

	}


	public void ChangeHeadWear( int type )
	{
		//change headwear
		PicoVRManager.SDK.currentDevice.ChangeHeadwear(type);
	}
}
