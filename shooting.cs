using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
	GameObject prefab;

	// Use this for initialization
	void Start () {
		prefab = Resources.Load ("ball") as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			GameObject ball = Instantiate (prefab) as GameObject;
			ball.transform.position = transform.position + ball.transform.forward * 2;
			Rigidbody rb = ball.GetComponent<Rigidbody>();
			rb.velocity = ball.transform.forward * 40;
		}

		}
}
