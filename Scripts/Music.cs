using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	string[] Boss;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
		Boss = new string[] {"1", "5", "9", "13", "17", "21"};
    }
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevelName == ("StartA") || Application.loadedLevelName == ("Blue Screen") || Application.loadedLevelName == ("KCodeScreen") || Application.loadedLevelName == ("Game Over")) {
			NMM ();
		}
		foreach (string Lvl in Boss) {
			if (Application.loadedLevelName == ("Boss" + Lvl)) {
				gameObject.GetComponent<AudioSource> ().volume = 0;
			}
		}
    }
	void FB () {
		StartCoroutine (THTGABFB ());
	}
	IEnumerator THTGABFB () {
		yield return new WaitForSeconds (0.25f);
		gameObject.GetComponent<AudioSource> ().volume = 0.5f;
	}
	void NMM () {
		Destroy (GameObject.Find ("MusicSlide"));
		Destroy(this.gameObject);
	}
}
