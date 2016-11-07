using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class obstructionController : MonoBehaviour {

    private Sprite[] sprites;
    private List<GameObject> balloons;
    public float balloonSpeedX = 10f;
    public float balloonSpeedY = 0.0000000001f;

	// Use this for initialization
	void Start () {
        balloons = new List<GameObject>();
        sprites = new Sprite[9];
        for (int i=1; i<=sprites.Length; i++)
        {
            sprites[i-1] = Resources.Load<Sprite>("Art/balloon_" + i);
        }
	}
	
	// Update is called once per frame
	void Update () {
	    if (Random.Range(0,100) == 0)
        {
            Debug.Log("Balloon");
            GameObject balloon = (GameObject)Instantiate(Resources.Load("Prefabs/balloon"));
            balloon.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, 9)];
            balloon.transform.position = new Vector3(9.7f, -6f, -3f);
            balloons.Add(balloon);
        }
        for (int i=0; i<balloons.Count; i++)
        {
            if ((balloons[i].transform.position.x <= -10.8f) || (balloons[i].transform.position.y >= 6f))
            {
                Debug.Log("Remove");
                Destroy(balloons[i]);
                balloons.RemoveAt(i);
            }
            else
            {
                balloons[i].transform.Translate(new Vector3(-balloonSpeedX, balloonSpeedY));
            }
        }
	}
}
