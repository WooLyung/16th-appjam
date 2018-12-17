using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Move : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public GameObject player, playerparent;
    public float speed;
    public Transform Camera;
    int dir;
    bool isGoing = false;
    Animator animator;

    private void Awake()
    {
        animator = player.GetComponent<Animator>();
    }

	void Update () {
        if (isGoing)
        {
            playerparent.transform.Translate(new Vector3(speed * Time.deltaTime * dir, 0, 0));
        }
    }

    public void OnPointerDown(PointerEventData eventData)   
    {
        isGoing = true;
        if (gameObject.name == "left")
        {
            player.transform.rotation = new Quaternion(0, 180, 0, 0);
            dir = -1;
        }
        else
        {
            player.transform.rotation = new Quaternion(0, 0, 0, 0);
            dir = 1;
        }

        animator.SetBool("Move", true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isGoing = false;
        animator.SetBool("Move", false);
    }
}
