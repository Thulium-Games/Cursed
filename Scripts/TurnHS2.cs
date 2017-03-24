using UnityEngine;
using System.Collections;

public class TurnHS2 : MonoBehaviour {
    float HMove;
    float VMove;
    // Use this for initialization
    void Start() {
        transform.Rotate(-transform.rotation.x, -transform.rotation.y, -transform.rotation.z);
        VMove = 5;
        HMove = 5;
    }

    // Update is called once per frame
    void FixedUpdate() {
        transform.Rotate(VMove * 0.05f, HMove * 0.05f, 0);
        if (Input.GetKey(KeyCode.UpArrow)) {
            ++VMove;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            --VMove;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            --HMove;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            ++HMove;
        }
        if (Mathf.Abs(VMove) > 1000 || Mathf.Abs(HMove) > 1000) {
            Application.LoadLevel("Blue Screen");
        }
    }
}