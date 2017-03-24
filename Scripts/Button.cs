using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	Door door;
	public string[] FTRB;
	public Vector3 Dctn;
	Move move;
	// Update is called once per frame
	void FixedUpdate () {
		foreach (string FD in FTRB) {
			door = GameObject.Find (FD).GetComponent (typeof(Door)) as Door;
			if (Physics.Raycast (transform.position, Dctn, 0.26f)) {
				door.SendMessage ("Butt");
				move = GameObject.Find ("Player").GetComponent (typeof(Move)) as Move;
				move.SendMessage ("NOGURG");
				Destroy (this.gameObject);
			}
		}
	}
}

