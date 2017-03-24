using UnityEngine;
using System.Collections;

public class BossMove4 : MonoBehaviour {
	Music Msic;
	// Use this for initialization
	void Start () {
		Msic = GameObject.Find("Main Theme").GetComponent(typeof(Music)) as Music;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y < 3 && Input.GetKeyDown(KeyCode.UpArrow)) {
			transform.Translate(0, 3, 0);
		}
		if (transform.position.y > -3 && Input.GetKeyDown(KeyCode.DownArrow)) {
			transform.Translate(0, -3, 0);
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