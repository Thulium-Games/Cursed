using UnityEngine;
using System.Collections;

public class BossMove2 : MonoBehaviour {
	Music Msic;
	 public float Hight;
	float Air;
	bool OnGround;
	// Use this for initialization
	void Start () {
		Msic = GameObject.Find("Main Theme").GetComponent(typeof(Music)) as Music;
	}
	
	// Update is called once per frame
	void Update () { 
		if (transform.position.y < 5.5f && Input.GetKey (KeyCode.UpArrow) && Hight <= 9) {
			transform.Translate (0, 10 * Time.deltaTime, 0);
		} else if (!OnGround) {
			Hight = 10;
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
        if (transform.position.y > -5.5f && Input.GetKey(KeyCode.DownArrow)) {
			Hight = 10;
			transform.Translate(0, -10 * Time.deltaTime, 0);
        }
		if (transform.position.x > -10.5f && Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(-10 * Time.deltaTime, 0, 0);
		}
		if (transform.position.x < 10.5f && Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(10 * Time.deltaTime, 0, 0);
		}
	}
	void FixedUpdate () {
		//Movement
		RaycastHit Hit;
		Physics.SphereCast (transform.position, 0.4f, Vector3.down, out Hit, 10f);
		Air = Hit.distance;
		if (Air < 0.125f) {
			OnGround = true;
		 } else {
			OnGround = false;
		}
		if (Hight < Air) {
			Hight = Air;
		} else if (OnGround) {
			Hight = 0;
		}
	}
	void OnCollisionStay (Collision Hit) {
		if (Hit.gameObject.tag == ("Respawn") || Hit.gameObject.tag == ("Finish")) {
			Application.LoadLevel ("L5");
			Msic.SendMessage ("FB");
		}
		if (Input.GetKeyUp (KeyCode.Escape)) {
			Application.LoadLevel ("Start");
		}
	}
}