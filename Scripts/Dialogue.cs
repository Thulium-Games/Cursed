using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {
	public string Name;
	public string[] Words;
	public string[] Questions;
	public int[] QuestNext;
	int AnsNum;
	public int[] WordsNext;
	public int NextText;
	int Questint;
	public Text text;
	public Text Qtext;
	public Text NameText;
	public Image TextBox;
	public bool CanCont;
	public bool DoWords;
	public int frame;
	// Use this for initialization
	void Start () {
		frame = 0;
		NextText = 0;
		AnsNum = 1;
		text.text = "";
		Qtext.text = "";
		NameText.text = "";
		TextBox.color = new Color32 (20, 20, 90, 0);
	}
	void Update () {
		if (CanCont) {
			if (Input.GetKeyDown (KeyCode.Return) && AnsNum >= 1) {
				CanCont = false;
				frame = 10;
				Questint = 0;
			}
			if (Input.GetKeyDown (KeyCode.RightShift) && AnsNum >= 2) {
				CanCont = false;
				frame = 10;
				Questint = 1;
			}
			if (Input.GetKeyDown (KeyCode.Backspace) && AnsNum >= 3) {
				CanCont = false;
				frame = 10;
				Questint = 2;
			}
			if (Input.GetKeyDown (KeyCode.Backslash) && AnsNum >= 4) {
				CanCont = false;
				frame = 10;
				Questint = 3;
			}
		}
	}
	// Update is called once per frame
	IEnumerator DoTalking () {
		if (DoWords) {
			CanCont = false;
			frame = 0;
			text.text = "";
			Qtext.text = "";
			foreach (char Ch in Words[NextText].ToCharArray()) {
				text.text += Ch;
				if (Ch == '.' || Ch == '!' || Ch == '?') {
					yield return new WaitForSeconds (0.125f);
				} else if (Ch == ',') {
					yield return new WaitForSeconds (0.0625f);
				} else {
					yield return new WaitForSeconds (0.025f);
				}
			}
			if (WordsNext [NextText] == 1000) {
				foreach (char Ch in Questions[NextText].ToCharArray()) {
					if (Ch == '/') {
						Qtext.text += Ch;
						Qtext.text = Qtext.text.Replace (Ch, '\n');
					} else if (Ch == '1') {
						AnsNum = 1;
					} else if (Ch == '2') {
						AnsNum = 2;
					} else if (Ch == '3') {
						AnsNum = 3;
					} else if (Ch == '4') {
						AnsNum = 4;
					} else {
						Qtext.text += Ch;
					}
					yield return new WaitForSeconds (0.005f);
				}
				CanCont = true;
				yield return new WaitWhile (() => frame < 10);
				NextText = QuestNext [NextText + Questint];
				StartCoroutine (DoTalking ());
			} else {
				CanCont = true;
				yield return new WaitWhile (() => frame < 10);
				AnsNum = 1;
				if (WordsNext [NextText] < 0) {
					NextText = WordsNext [NextText];
					NextText = -NextText;
					Vars.Talking = false;
					DoWords = false;
					text.text = "";
					NameText.text = "";
					TextBox.color = new Color32 (20, 20, 90, 0);
				} else {
					NextText = WordsNext [NextText];
				}
				StartCoroutine (DoTalking ());
			}
		}
	}
	void OnTriggerStay () {
		if (Input.GetKeyDown (KeyCode.Return) && !DoWords) {
			Vars.Talking = true;
			DoWords = true;
			NameText.text = Name;
			TextBox.color = new Color32 (20, 20, 90, 150);
			StartCoroutine (DoTalking ());
		}
	}
}