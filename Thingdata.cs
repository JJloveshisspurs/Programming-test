using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Thingdata  {

    //*** Thing data is a class that holds reference to the individual " thing " 
    //*** game objects and also has the assigned distance value for the given objects position
    //*** We use this data to sort the objects by position later

    //*** This is a reference to the thing class script on the thing gameobjects
	public Thing thingClass;

    //*** The given gameobject
	public GameObject gameObject;

    //*** Distance of object from player (Jonathan) center 
	public float distance;


	public void SetMaterialColor(){

        //*** Let's set the color of the closest thing   
		thingClass.SetThingClosestColor ();

	}
}
