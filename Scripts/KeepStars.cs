using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepStars : MonoBehaviour {
	public static int Strs;
	public static int Nums;

	void Start () {
		DontDestroyOnLoad (this.gameObject);
	}

	void Update () {
		if (PlayerPrefs.GetInt ("Score", 1) < Move.keepLev) {
			PlayerPrefs.SetInt ("Score", Move.keepLev);
		}
		Nums = PlayerPrefs.GetInt ("Score", 1);
	}
}