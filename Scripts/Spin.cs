using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
	public int i;
	// Use this for initialization
	void Start () {
		i = 0;
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (i < 6362.5f) {
			transform.Rotate (10 * Time.deltaTime, 10 * Time.deltaTime, 0);
			++i;
		} else {
			transform.Rotate (0,0,0);
		}
	}
}
