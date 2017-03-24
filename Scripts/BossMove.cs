using UnityEngine;
using System.Collections;

public class BossMove : MonoBehaviour {
	Music Msic;
	// Use this for initialization
	void Start () {
		Msic = GameObject.Find("Main Theme").GetComponent(typeof(Music)) as Music;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < 5.5f && Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(0, 10 * Time.deltaTime, 0);
        }
        if (transform.position.y > -5.5f && Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(0, -10 * Time.deltaTime, 0);
        }
		if (transform.position.x > -10.5f && Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(-10 * Time.deltaTime, 0, 0);
		}
		if (transform.position.x < 10.5f && Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(10 * Time.deltaTime, 0, 0);
		}
	}
	void OnCollisionStay (Collision Hit) {
		if (Hit.gameObject.tag == ("Respawn") || Hit.gameObject.tag == ("Finish")) {
			Application.LoadLevel ("L9");
			Msic.SendMessage ("FB");
		}
		if (Input.GetKeyUp (KeyCode.Escape)) {
			Application.LoadLevel ("Start");
		}
	}
}