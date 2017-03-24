using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class MoveCan : MonoBehaviour {
	Canvas peepee;
	WWW www;
	AudioSource WinSound;
	int i;
	void Start () {
		peepee = GetComponent<Canvas>();
		WinSound = gameObject.AddComponent<AudioSource> ();
		WinSound = gameObject.GetComponent<AudioSource> ();
		i = 0;
	}

	void Fin () {
		peepee.targetDisplay = (0);
		for (; i < 1; i++) {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Victory.wav"));
		}
	}
	IEnumerator LoadAudio1(string path) {
		www = new WWW (path);
		yield return www;
		WinSound.clip = www.audioClip;
		WinSound.Play ();
		WinSound.PlayDelayed (44100);
	}
}
