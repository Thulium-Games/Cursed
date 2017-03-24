using UnityEngine;
using System.Collections;

public class LevSelMo : MonoBehaviour {
    int Lvl;
	// Use this for initialization
	void Start () {
        Lvl = 0;
    }
	
	// Update is called once per frame
	void Update () { 
        if (Lvl < 0) {
            transform.Translate(420, 0, 0);
            Lvl = 9;
        }
        if (Lvl > 9)
        {
            transform.Translate(-420, 0, 0);
            Lvl = 0;
        }

		if (Input.GetKeyDown (Move.LeftPress)) {
			transform.Translate(-42, 0, 0);
            --Lvl;
        }
	
		if (Input.GetKeyDown (Move.RightPress)) {
            transform.Translate(42, 0, 0);
            ++Lvl;
        }
	}
}