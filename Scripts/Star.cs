using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class Star : MonoBehaviour {
	public bool MoveStar;
	public static int ATS;
	WWW www;
	AudioSource star;
	// Use this for initialization
	void Start () {
		ATS = PlayerPrefs.GetInt ("GotStar", 0);
		star = gameObject.AddComponent<AudioSource> ();
		star = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		PlayerPrefs.SetInt ("GotStar", ATS);
		PlayerPrefs.GetInt ("GotStar" + Application.loadedLevelName + this.gameObject.name, 0);
		if (Physics.Raycast (transform.position, new Vector3 (0, 0, 1), 1) && PlayerPrefs.GetInt ("GotStar" + Application.loadedLevelName + this.gameObject.name, 0) == 0) {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Star.wav"));
			MoveStar = true;
			Instantiate (GameObject.Find ("Get Star"), transform.position, transform.rotation);
			transform.Translate (0, 1000, 0);
			++ATS;
			PlayerPrefs.SetInt ("GotStar" + Application.loadedLevelName + this.gameObject.name, 1);
		} else if (Physics.Raycast (transform.position, new Vector3 (0, 0, 1), 1) && PlayerPrefs.GetInt ("GotStar" + Application.loadedLevelName + this.gameObject.name, 0) == 1) {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Star.wav"));
			MoveStar = true;
			Instantiate (GameObject.Find ("Get Star"), transform.position, transform.rotation);
			transform.Translate (0, 1000, 0);
		}
	}
	IEnumerator LoadAudio1(string path) {
		www = new WWW (path);
		yield return www;
		star.clip = www.audioClip;
		star.Play ();
		star.PlayDelayed (44100);
	}
}