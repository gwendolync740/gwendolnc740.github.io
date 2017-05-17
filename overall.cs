using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overall : MonoBehaviour {
	public GameObject mover;
	public GameObject[] enemies;
	public Renderer rend;
	Vector3 moverOrigin; 

	// Use this for initialization
	void Start () {
		moverOrigin = mover.transform.position;
		for (int i = 0; i < 18; i++) {

		}
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("game object is at..." + mover.transform.position);

		if (Input.GetKeyDown (KeyCode.A)) {
			mover.transform.position += new Vector3 (-1,0,0);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			mover.transform.position += new Vector3 (1, 0, 0);
		}

		if ((mover.transform.position.x > 5)
		    || (mover.transform.position.x < -5)) {
			mover.transform.position = moverOrigin;
		}
		
	}

	void OnCollisionEnter (Collision balloons){
		if(balloons.gameObject.tag == "balloon"){
			Destroy(gameObject);
			rend.material.color = Color.clear;
		}

	}
}
