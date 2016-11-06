using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class backgroundController : MonoBehaviour
{
	public List<GameObject> clouds;
    public GameObject buildings1, buildings2;
	public float buildingSpeed = 0.01f;
	public float cloudSpeed = 0.02f;

	// Use this for initialization
	void Start ()
	{
		buildings1 = (GameObject) Instantiate(Resources.Load("buildingPrefab"));
		buildings1.transform.Translate(new Vector3 (-6f, -5f, 0f));
		buildings2 = (GameObject) Instantiate(Resources.Load("buildingPrefab"));
		buildings2.transform.Translate(new Vector3 (24.82f, -5f, 0f));
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
		int chance = UnityEngine.Random.Range (0, 1000);
		if (chance == 0) {
			GameObject cloud = (GameObject)Instantiate (Resources.Load ("Cloud"));
			if (UnityEngine.Random.Range (0, 2) == 0) {
				SpriteRenderer sprite = cloud.GetComponent<SpriteRenderer>();
				sprite.sprite = (SResources.Load ("cloud_small");
			} else {
				SpriteRenderer sprite = cloud.GetComponent<SpriteRenderer>();
				sprite.sprite = Resources.Load ("cloud_big");
			}
			clouds.Add (cloud);
		}
		foreach (GameObject currentCloud in clouds) {
			if (currentCloud.transform.position.x <= -6.8f) {
				clouds.Remove (currentCloud);
			}
			currentCloud.transform.Translate(new Vector3(-cloudSpeed, 0f));
		}

	}
}