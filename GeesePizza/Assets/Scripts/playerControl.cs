using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {
	private static float g = 2;
	private float lastSpeed;

	// Use this for initialization
	void Start () {
		lastSpeed = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		float input_y = Input.GetAxisRaw ("Vertical");

		//Debug.Log (input_y);
		if (input_y == -1) {
			input_y *= lastSpeed - (g*2 * Time.deltaTime);
		} else if (input_y == 1) {
			input_y *= lastSpeed + (g * Time.deltaTime);
		} else {
			input_y = lastSpeed - (4 * g * Time.deltaTime);
		}
		lastSpeed = input_y;
		Debug.Log (lastSpeed);
		transform.Translate (new Vector3(0f, input_y));
	}
}