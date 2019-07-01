using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jonathan : MonoBehaviour {

    //*** List of thing objects
	public List<Thingdata> things = new List<Thingdata> (); 

    //*** List of thing Object distances
	public List<float> thingDistances = new List<float>();

    //the timer for updating the thing distances
	public float updateTimer;

    //*** The rate at which we update the things
	public float UpdateTimeInterval = .2f;

	// Use this for initialization
	void Start () {
        //*** Our initial find of the closest thing object
		FindClosestThing ();
	}
	
	// Update is called once per frame
	void Update () {

        //*** Update timer
		updateTimer += Time.deltaTime; 

        //*** Check time interval
		if (updateTimer > UpdateTimeInterval) {

			updateTimer = 0f;
			FindClosestThing ();
		}

	}


	public void FindClosestThing(){

        //*** reset all things during starting frame
		ResetThings ();

        //*** Initialize distance value
		float oDistance = 0f;

        //*** Iterate through list of things
		for (int i = 0; i < things.Count; i++) {


            //*** Calculate distance for thing object at index i
			oDistance = Vector3.Distance(things[i].gameObject.transform.position, this.gameObject.transform.position); 

            //*** Set distance
			things [i].distance = oDistance;
		}

        //*** Sort things by distance after iteration
		things.Sort (SortByDistance);

        //*** Set the top most ( closest) thing object to Red
		things [0].SetMaterialColor ();
	}

	public void ResetThings(){

        //*** Iterate through and reset things
		for (int i = 0; i < things.Count; i++) {

			things [i].thingClass.ResetThingColor ();

		}


	}



	//*** Sort thing classes by distance
	static int SortByDistance(Thingdata p1, Thingdata p2)
	{
		return p1.distance.CompareTo(p2.distance);
	}
}
