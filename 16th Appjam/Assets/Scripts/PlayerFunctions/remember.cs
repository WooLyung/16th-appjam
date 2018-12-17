using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class remember : MonoBehaviour
{

    public Text piece;

    // Use this for initialization
    void Start()
    {
        piece.text = "x" + DataManager.count.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
