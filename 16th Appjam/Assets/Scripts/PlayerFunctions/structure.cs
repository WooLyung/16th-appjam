using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class structure : MonoBehaviour {

    public Text confirm;
    public Transform player;
    bool trigger = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(player.position, transform.position) < 5f)
        {
            if (trigger == false)
            {
                switch (gameObject.name)
                {
                    case "InGame1": confirm.text = "영화관"; break;
                    case "InGame2": confirm.text = "가로수길"; break;
                    case "InGame3": confirm.text = "바다"; break;
                    case "InGame4": confirm.text = "집"; break;
                }
                trigger = true;
            }
        }
        else
        {
            if (trigger)
            {
                confirm.text = "확인";
                trigger = false;
            }
        }
	}

}
