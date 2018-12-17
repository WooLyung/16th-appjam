using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Theater : MonoBehaviour
{
    public GameObject sleep;
    public GameObject angry;

    private void Start()
    {
        StartCoroutine("StartAnimation");
    }

    IEnumerator StartAnimation()
    {
        yield return new WaitForSeconds(2);
        sleep.SetActive(true);
        yield return new WaitForSeconds(2);
        angry.SetActive(true);
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("InGame1");
    }
}
