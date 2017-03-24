using UnityEngine;
using System.Collections;

public class AnimSwch : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Wt ());

    }

    // Update is called once per frame
    IEnumerator Wt () {
        yield return new WaitForSeconds(10.5f);
        Application.LoadLevel("Start");
	}
}
