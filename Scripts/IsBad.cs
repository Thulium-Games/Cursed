using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsBad : MonoBehaviour {
	int Level;
	// Use this for initialization
	void Start () {
		Level = Random.Range (1, 25);
		if (Level == 1) {
			Application.LoadLevel ("StartDie");
		} else {
			Application.LoadLevel ("Start1");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
