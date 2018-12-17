using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Road : MonoBehaviour
{
    public GameObject angry;

    private void Start()
    {
        StartCoroutine("StartAnimation");
    }

    IEnumerator StartAnimation()
    {
        yield return new WaitForSeconds(2);
        angry.SetActive(true);
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("InGame2");
    }
}