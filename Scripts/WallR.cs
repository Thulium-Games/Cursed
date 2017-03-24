using UnityEngine;
using System.Collections;

public class WallR : MonoBehaviour {
	Move move;
	// Use this for initialization
	void Start () {
		move = GameObject.Find ("Player").GetComponent (typeof(Move)) as Move;
	}

	// Update is called once per frame
	void OnTriggerEnter () {
		move.SendMessage ("OWR");
	}
	void OnTriggerExit () {
		move.SendMessage ("NOWR");
	}
}