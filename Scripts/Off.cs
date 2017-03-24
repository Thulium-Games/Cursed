using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class Off : MonoBehaviour {
	AudioSource XBO;
	AudioSource Explode;
	bool OnOff;
	public int clicks;
	// Use this for initialization
	void Start () {
		XBO = GetComponent<AudioSource> ();
		Explode = GameObject.Find ("Die").GetComponent<AudioSource> ();
		OnOff = true;
		clicks = 0;
	}
	// Update is called once per frame
	void Update () {
		if (clicks >= 32 && clicks < 66) {
			Explode.volume = 0.5f;
		} else if (clicks >= 66) {
			Explode.volume = 1;
		} else {
			Explode.volume = 0;
		}
		if (clicks > 99) {
			if (Explode.time > 1) {
				Application.LoadLevel ("Conglat");
			}
		} else {
			Explode.Play ();
			Explode.Play (44100);
		}
	}
	void Click () {
		XBO.Play ();
		XBO.Play (44100);
		++clicks;
		if (OnOff) {
			GameObject.Find ("ImageC").GetComponent<Image> ().color = new Color32 (000, 000, 000, 100);
			GameObject.Find ("ImageRR").transform.Translate (0, -1000, 0);
			OnOff = false;
		} else {
			GameObject.Find ("ImageC").GetComponent<Image> ().color = new Color (255, 255, 255, 255);
			GameObject.Find ("ImageRR").transform.Translate (0, 1000, 0);
			OnOff = true;
		}
	}
}
