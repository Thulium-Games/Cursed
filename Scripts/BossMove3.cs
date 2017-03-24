using UnityEngine;
using System.Collections;

public class BossMove3 : MonoBehaviour {
	GameObject Dm1;
	GameObject Dm2;
	GameObject Cam;
	GameObject Player;
	public Rigidbody RB;
	Music Msic;
	// Use this for initialization
	void Start () {
		Dm1 = GameObject.Find ("DeathMove1");
		Dm2 = GameObject.Find ("DeathMove2");
		Cam = GameObject.Find ("Main Camera");
		Player = GameObject.Find ("Player");
		Msic = GameObject.Find("Main Theme").GetComponent(typeof(Music)) as Music;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y == -5.5f && Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate(0, 11, 0);
			Cam.transform.Rotate (0, 180, 0);
			Cam.transform.Translate (0, 0, -10);
			Cam.transform.Rotate (0, 0, 180);
			Player.transform.Rotate (0, 0, 180);
			Dm1.transform.localScale = new Vector3 (1, -Dm1.transform.lossyScale.y, 1);
			Dm2.transform.localScale = new Vector3 (1, -Dm2.transform.lossyScale.y, 1);
		}
		if (transform.position.y == -5.5f && Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate(0, 11, 0);
			Cam.transform.Rotate (0, 180, 0);
			Cam.transform.Translate (0, 0, -10);
			Cam.transform.Rotate (0, 0, 180);
			Player.transform.Rotate (0, 0, 180);
			Dm1.transform.localScale = new Vector3 (1, -Dm1.transform.lossyScale.y, 1);
			Dm2.transform.localScale = new Vector3 (1, -Dm2.transform.lossyScale.y, 1);
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
			Application.LoadLevel ("L13");
			Msic.SendMessage ("FB");
		}
		if (Input.GetKeyUp (KeyCode.Escape)) {
			Application.LoadLevel ("Start");
		}
	}
}