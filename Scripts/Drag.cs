using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {
	Vector3 MPos;
	bool drag;
	public GameObject TO;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MPos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);
		if (drag) {
			transform.position = Vector3.Lerp (transform.position, MPos, 1); 
		}
	}
	void IsClick () {
		if (drag) {
			drag = false;
		} else {
			drag = true;
		}
	}
	void OnCollisionStay (Collision Hit) {
		if (Hit.gameObject.name == TO.name) {
			if (TO.name == ("TFY")) {
				Debug.Log ("Hi");
				Play.isY = true;
			} else if (TO.name == ("TFE")) {
				Play.isE = true;
			} else if (TO.name == ("TFN")) {
				Play.isN = true;
			} else if (TO.name == ("TFO")) {
				Play.isO = true;
			}
		} else {
			if (TO.name == ("TFY")) {
				Play.isY = false;
			} else if (TO.name == ("TFE")) {
				Play.isE = false;
			} else if (TO.name == ("TFN")) {
				Play.isN = false;
			} else if (TO.name == ("TFO")) {
				Play.isO = false;
			}
		}
	}
}
