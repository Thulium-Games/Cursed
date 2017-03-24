using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	Canvas peepee;
	// Use this for initialization
	void Start () {
		peepee = GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			pause ();
		}
	}
	void pause () {
		if (peepee.targetDisplay == (1)) {
			peepee.targetDisplay = (0);
		} else if (peepee.targetDisplay == (0)) {
			peepee.targetDisplay = (1);
		}
	}
}
