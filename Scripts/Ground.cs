using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {
	Move move;
	// Use this for initialization
	void Start () {
		move = GameObject.Find ("Player").GetComponent (typeof(Move)) as Move;
	}
	
	// Update is called once per frame
	void OnTriggerStay () {
		move.SendMessage ("OG");
	}
	void OnTriggerExit () {
		move.SendMessage ("NOG");
	}
}
