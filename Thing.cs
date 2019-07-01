using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thing : MonoBehaviour {

	public MeshRenderer thingMat;


	// Use this for initialization
	void Start () {
		
	}
	
	public void SetThingClosestColor(){
		thingMat.materials [0].color = Color.red;
	}

	public void ResetThingColor(){

		thingMat.materials [0].color = Color.white;

	}


}
