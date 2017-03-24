using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inputs : MonoBehaviour {
	KeyCode TK;
	bool CK;
	public GameObject TO;
	public int TOTC;
	// Use this for initialization
	void Start () {
		if (Move.LeftPress == KeyCode.None) {
			Move.LeftPress = KeyCode.LeftArrow;
		}
		if (Move.RightPress == KeyCode.None) {
			Move.RightPress = KeyCode.RightArrow;
		}
		if (Move.JumpPress == KeyCode.None) {
			Move.JumpPress = KeyCode.UpArrow;
		}
		if (TOTC == 0) {
			TK = Move.LeftPress;
			TO.GetComponent<Text> ().text = ("" + TK);
		} else if (TOTC == 1) {
			TK = Move.RightPress;
			TO.GetComponent<Text> ().text = ("" + TK);
		} else {
			TK = Move.JumpPress;
			TO.GetComponent<Text> ().text = ("" + TK);
		}
	}
	
	// Update is called once per frame
	public void Update () {
		if (CK) {
			foreach (KeyCode KCode in System.Enum.GetValues(typeof(KeyCode))) {
				if (Input.GetKeyDown (KCode)) {
					TK = KCode;
					if (TOTC == 0) {
						Move.LeftPress = KCode;
					} else if (TOTC == 1) {
						Move.RightPress = KCode;
					} else {
						Move.JumpPress = KCode;
					}
					TO.GetComponent<Text> ().text = ("" + KCode);
					CK = false;
				}
			}
		} else {
			if (TOTC == 0) {
				TK = Move.LeftPress;
				TO.GetComponent<Text> ().text = ("" + TK);
			} else if (TOTC == 1) {
				TK = Move.RightPress;
				TO.GetComponent<Text> ().text = ("" + TK);
			} else {
				TK = Move.JumpPress;
				TO.GetComponent<Text> ().text = ("" + TK);
			}
		}
	}
	void Input1 () {
		CK = true;
		TO.GetComponent<Text> ().text = "PressAnyKey";
	}
}
