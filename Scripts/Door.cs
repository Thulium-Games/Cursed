using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	public float Distx;
	public float Disty;
	public float Distz;
	public bool DYWTUG;
	bool StartThings;
	Move Player;
	public Rigidbody RB;
	void Butt () {
		RB.useGravity = DYWTUG;
		RB.AddForce (Distx * 100, Disty * 100, Distz * 100);
		Player = GameObject.Find ("Player").GetComponent (typeof(Move)) as Move;
		Player.OnGround = false;
	}
}
