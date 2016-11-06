using UnityEngine;
using System;
using System.Collections;

public class backgroundController : MonoBehaviour
{

    private GameObject buildings1, buildings2;

	// Use this for initialization
	void Start ()
	{
	    buildings1 = Instantiate(buildings1, new Vector3(0f, 0f, 0f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
