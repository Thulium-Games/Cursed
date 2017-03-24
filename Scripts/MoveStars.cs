using UnityEngine;
using System.Collections;

public class MoveStars : MonoBehaviour {
	int i;
	public int AddLives;
	Star star1;
	Star star2;
	Star star3;
	// Use this for initialization
	void Start () {
		i = 0;
		star1 = GameObject.Find("Star1").GetComponent(typeof(Star)) as Star;
		star2 = GameObject.Find("Star2").GetComponent(typeof(Star)) as Star;
		star3 = GameObject.Find("Star3").GetComponent(typeof(Star)) as Star;
	}
	// Update is called once per frame
	void Update () {
		if (star1.MoveStar && !star2.MoveStar && !star3.MoveStar || !star1.MoveStar && star2.MoveStar && !star3.MoveStar || !star1.MoveStar && !star2.MoveStar && star3.MoveStar) {
				AddLives = 1;
			}
		if (star1.MoveStar && star2.MoveStar && !star3.MoveStar || star1.MoveStar && !star2.MoveStar && star3.MoveStar || !star1.MoveStar && star2.MoveStar && star3.MoveStar) {
				AddLives = 2;
			}
		if (star1.MoveStar && star2.MoveStar && star3.MoveStar) {
				AddLives = 3;
			}
		if (star1.MoveStar && GameObject.Find ("StarEL1") == this.gameObject || star1.MoveStar && GameObject.Find ("StarEL1O") == this.gameObject) {
			if (GameObject.Find ("StarEL1") == this.gameObject) {
				for (; i < 1; i++) {
					transform.Translate (0, -800, 0);
				}
			} else {
				for (; i < 1; i++) {
					transform.Translate (0, -5000, 0);
				}
			}
		}
		if (star2.MoveStar && GameObject.Find ("StarEL2") == this.gameObject || star2.MoveStar && GameObject.Find ("StarEL2O") == this.gameObject) {
			if (GameObject.Find ("StarEL2") == this.gameObject) {
				for (; i < 1; i++) {
					transform.Translate (0, -800, 0);
				}
			} else {
				for (; i < 1; i++) {
					transform.Translate (0, -5000, 0);
				}
			}
		}
		if (star3.MoveStar && GameObject.Find ("StarEL3") == this.gameObject || star3.MoveStar && GameObject.Find ("StarEL3O") == this.gameObject) {
			if (GameObject.Find ("StarEL3") == this.gameObject) {
				for (; i < 1; i++) {
					transform.Translate (0, -800, 0);
				}
			} else {
				for (; i < 1; i++) {
					transform.Translate (0, -5000, 0);
				}
			}
		}
	}
}