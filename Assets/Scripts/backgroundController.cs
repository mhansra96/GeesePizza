using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class backgroundController : MonoBehaviour
{
	public List<GameObject> clouds;
    public GameObject buildings1, buildings2;
	public float buildingSpeed = 0.01f;
	public float cloudSpeed = 0.025f;

	// Use this for initialization
	void Start ()
	{
		buildings1 = (GameObject) Instantiate(Resources.Load("Prefabs/buildingPrefab"));
		buildings1.transform.Translate(new Vector3 (-6f, -5f, -1f));
		buildings2 = (GameObject) Instantiate(Resources.Load("Prefabs/buildingPrefab"));
		buildings2.transform.Translate(new Vector3 (24.82f, -5f, -1f));
	}
	
	// Update is called once per frame
	void Update () {
		if (buildings1.transform.position.x <= -36.82f) {
			buildings1.transform.Translate(new Vector3(30.82f,0f));
		}
		if (buildings2.transform.position.x <= -36.82f) {
					buildings2.transform.Translate(new Vector3(30.82f,0f));
		}
		buildings1.transform.Translate(new Vector3(-buildingSpeed,0f));
		buildings2.transform.Translate(new Vector3(-buildingSpeed,0f));
		int chance = UnityEngine.Random.Range (0, 120);
		if (chance == 0) {
			//Debug.Log ("cloud");
			GameObject cloud = null;
			if (UnityEngine.Random.Range (0, 2) == 0) {
				cloud = (GameObject)Instantiate (Resources.Load ("Prefabs/Cloud_Small"));
				cloud.transform.position = (new Vector3(10f,UnityEngine.Random.Range(-2,7),UnityEngine.Random.Range(-4,-1)));
			} else {
				cloud = (GameObject)Instantiate (Resources.Load ("Prefabs/Cloud_Big"));
				cloud.transform.position = (new Vector3(10f,UnityEngine.Random.Range(-2,7),UnityEngine.Random.Range(-4,-1)));
			}
			if (cloud != null) {
				clouds.Add (cloud);
			}
		}
		/*foreach (GameObject currentCloud in clouds) {
			if (currentCloud.transform.position.x <= -10.8f) {
				Debug.Log ("Remove");
				clouds.RemoveAll ();
			}

		}*/
		for (int i = 0; i < clouds.Count; i++) {
			if (clouds [i].transform.position.x <= -10.8f) {
				Debug.Log ("Remove");
				Destroy (clouds [i]);
				clouds.RemoveAt (i);
			}
			clouds[i].transform.Translate(new Vector3(-cloudSpeed, 0f));
		}
	}
}
