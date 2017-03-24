using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	public Vector3 WDITT;
	public Vector3 Dctn;
	public GameObject TITTTTT;
	public Vector3 AnyNum;
	public int MoreNums;
	AudioSource TP;
	Move move;
	WWW www;
	// Use this for initialization
	void Start () {
		TP = gameObject.AddComponent<AudioSource> ();
		TP = gameObject.GetComponent<AudioSource> ();
		move = GameObject.Find("Player").GetComponent(typeof(Move)) as Move;
	}
	
	// Update is called once per frame
	void Update () {
		move.KS = MoreNums;
		if (Physics.Raycast (transform.position, Dctn, 0.26f)) {
			StartCoroutine (LoadAudio1 ("File://" + Application.dataPath.Substring (0, Application.dataPath.LastIndexOf ("/")) + "/Assets/Sounds/Portal.wav"));
			WDITT = new Vector3 (TITTTTT.transform.position.x + AnyNum.x, TITTTTT.transform.position.y + AnyNum.y, TITTTTT.transform.position.z + AnyNum.z);
			move.GTN = WDITT;
			move.SendMessage ("Tpt");
		}
	}
	IEnumerator LoadAudio1(string path) {
		www = new WWW (path);
		yield return www;
		TP.clip = www.audioClip;
		TP.Play ();
		TP.PlayDelayed (44100);
	}
}
