using UnityEngine;
using System.Collections;

public class VTrackMove : MonoBehaviour {

	public int Drctn;
	public int Skedi;
	public float waittime;
	void Start () {
	}


	void Update () {
		Vector3 Bh = transform.TransformDirection (Vector3.forward);

		if (Physics.Raycast (transform.position, Bh, 1)) {
			if (Drctn == 0) {
				transform.Translate (0,Skedi * Time.deltaTime, 0);
			} else {
				transform.Translate (0,-Skedi * Time.deltaTime, 0);
			}
		} else {
			if (Drctn == 0) {
				StartCoroutine(Wat1());
			}
			if (Drctn == 1) {
				StartCoroutine(Wat2());
			}
		}
	}
	IEnumerator Wat1 () {
		Vector3 Bh = transform.TransformDirection (Vector3.forward);
		yield return new WaitForSeconds (waittime);
		if (!Physics.Raycast (transform.position, Bh, 1)) {
			transform.Translate (0,-Skedi * Time.deltaTime, 0);
			Drctn = 1;
		}
	}
	IEnumerator Wat2 () {
		Vector3 Bh = transform.TransformDirection (Vector3.forward);
		yield return new WaitForSeconds (waittime);
		if (!Physics.Raycast (transform.position, Bh, 1)) {
			transform.Translate (0,Skedi * Time.deltaTime, 0);
			Drctn = 0;
		}
	}
}