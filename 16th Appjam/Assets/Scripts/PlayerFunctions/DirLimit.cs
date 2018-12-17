using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirLimit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -7)
            transform.position = new Vector3(-7, transform.position.y, transform.position.z);
        if (transform.position.x > 30)
            transform.position = new Vector3(30, transform.position.y, transform.position.z);
    }
}
