using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Beach : MonoBehaviour
{
    public GameObject _camera;
    public GameObject no;

    private void Start()
    {
        StartCoroutine("StartAnimation");
    }

    IEnumerator StartAnimation()
    {
        yield return new WaitForSeconds(2);
        _camera.SetActive(true);
        yield return new WaitForSeconds(2);
        no.SetActive(true);
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("InGame3");
    }
}