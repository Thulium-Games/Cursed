using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class Play : MonoBehaviour {
	KeyCode[] KCode;
    Music Msic;
	Move keepScore;
	WWW www;
	int TPOTC;
	static public bool isY;
	static public bool isE;
	static public bool isN;
	static public bool isO;
	AudioSource Locked;

	void Start () {
		TPOTC = 0;
		KCode = new KeyCode[] {
			KeyCode.UpArrow,
			KeyCode.UpArrow,
			KeyCode.DownArrow,
			KeyCode.DownArrow,
			KeyCode.LeftArrow,
			KeyCode.RightArrow,
			KeyCode.LeftArrow,
			KeyCode.RightArrow,
			KeyCode.B,
			KeyCode.A
		};
		keepScore = GetComponent(typeof(Move)) as Move;
        Msic = GameObject.Find("Main Theme").GetComponent(typeof(Music)) as Music;
		Locked = gameObject.GetComponent<AudioSource> ();
	}
	void StartGame () {
		if (TPOTC == 10) {
			Application.LoadLevel ("KCodeScreen");
		} else {
			Application.LoadLevel ("Level Select");
		}
	}

	void Back () {
        if (GameObject.Find("Main Theme")) {
            Msic.SendMessage("NMM");
        }
		Destroy(GameObject.Find("KTOS"));
        Application.LoadLevel("Start");
	}
	void Sett () {
		Application.LoadLevel("Settings");
	}
	void Update () {
		if (Input.GetKeyDown (KCode [TPOTC])) {
			++TPOTC;
		} else if (Input.anyKeyDown) {
			TPOTC = 0;
		}
		if (isY && isE && isN && isO) {
			Application.LoadLevel ("Conglat");
		}
	}

	void Ii () {
		if (keepScore.score > -1) {
			Application.LoadLevel ("L1");
		} else {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Locked.wav"));
		}
	}

	void Iii () {
		if (keepScore.score > 4) {
			Application.LoadLevel ("L5");
		} else {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Locked.wav"));
		}
	}

	void Iiiv () {
		if (keepScore.score > 8) {
			Application.LoadLevel ("L9");
		} else {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Locked.wav"));
		}
	}

	void Iiv () {
		if (keepScore.score > 12) {
			Application.LoadLevel ("L13");
		} else {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Locked.wav"));
		}
	}

	void Iv () {
		if (keepScore.score > 16) {
			Application.LoadLevel ("L17");
		} else {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Locked.wav"));
		}
	}

	void Ivi () {
		if (keepScore.score > 20) {
			Application.LoadLevel ("L21");
		} else {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Locked.wav"));
		}
	}

	void Ivii () {
		if (keepScore.score > 24) {
			Application.LoadLevel ("L25");
		} else {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Locked.wav"));
		}
	}

	void Iiix () {
		if (keepScore.score > 28) {
			Application.LoadLevel ("L29");
		} else {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Locked.wav"));
		}
	}

	void Iix () {
		if (keepScore.score > 32) {
			Application.LoadLevel ("L33");
		} else {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Locked.wav"));
		}
	}

	void Ix () {
		if (keepScore.score > 36) {
			Application.LoadLevel ("L37");
		} else {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Locked.wav"));
		}
	}
	void EndGame () {
		Application.Quit ();
	}
	
	IEnumerator LoadAudio1(string path) {
		www = new WWW (path);
		yield return www;
		Locked.clip = www.audioClip;
		Locked.Play ();
		Locked.PlayDelayed (44100);
	}
}