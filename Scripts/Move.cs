using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public Animator Anim;
	public Rigidbody RB;
	bool OnGround;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!Vars.Talking) {
			transform.Rotate (0, Input.GetAxis ("Horizontal1") * 100 * Time.deltaTime, 0);
			if (OnGround) {
				Anim.SetFloat ("x", Input.GetAxis ("Horizontal"));	
				Anim.SetFloat ("z", Input.GetAxis ("Vertical"));
				Anim.SetFloat ("Blend", Input.GetAxis ("Fire1"));
			} else {
				Anim.SetFloat ("Blend", 0);
				Anim.SetFloat ("x", 0);	
				Anim.SetFloat ("z", 0);
			}
		} else {
			Anim.SetFloat ("Blend", 0);
			Anim.SetFloat ("x", 0);	
			Anim.SetFloat ("z", 0);
		}
	}
	void OnCollisionStay (Collision Hit) {
		OnGround = true;
	}
	void OnCollisionExit (Collision Hit) {
		OnGround = false;
	}
}
