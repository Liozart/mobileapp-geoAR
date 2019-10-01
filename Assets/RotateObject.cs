using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

    bool plus = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
            gameObject.transform.Rotate(0, 10 * Time.deltaTime, 0);
    }
}
