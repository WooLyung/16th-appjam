using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public float fadeSpeed = 1;
    public bool canTouch = false;
    
    private RectTransform center, top, bottom, all;
    private Image all_image, center_image, top_image, bottom_image;
    private AudioSource soundManager;

    public static ChangeScene Instance;

    public void SceneChange(string name)
    {
        gameObject.SetActive(true);
        StartCoroutine(SceneChangeCour(name));
    }

    private void Awake()
    {
        Instance = this;

        soundManager = GameObject.Find("SoundManager").GetComponent<AudioSource>();

        all = transform.Find("all").GetComponent<RectTransform>();
        center = transform.Find("center").GetComponent<RectTransform>();
        top = transform.Find("top").GetComponent<RectTransform>();
        bottom = transform.Find("bottom").GetComponent<RectTransform>();

        all_image = transform.Find("all").GetComponent<Image>();
        center_image = transform.Find("center").GetComponent<Image>();
        top_image = transform.Find("top").GetComponent<Image>();
        bottom_image = transform.Find("bottom").GetComponent<Image>();
    }
    
    private void Start()
    {
        StartFunc();
    }

    private void StartFunc()
    {
        StartCoroutine("StartCour");
    }

    IEnumerator StartCour()
    {
        WaitForSeconds waitTime = new WaitForSeconds(fadeSpeed);

        for (int i = 1; i <= 80; i++)
        {
            soundManager.volume = DataManager.Instance.volume_backgroundMusic * i / 80f;

            if (i <= 20)
            {
                all_image.color = new Color(1, 1, 1, 1 - i * 0.05f);
            }
            center.localScale = new Vector3(1, i * 0.032f, 1);
            bottom.localScale = new Vector3(1, 1 - i * 0.024f, 1);
            top.localScale = new Vector3(1, 1 - i * 0.024f + 0.04f, 1);

            if (i >= 40)
            {
                center_image.color = new Color(1, 1, 1, 1 - (i - 50) * 0.04f);
                top_image.color = new Color(1, 1, 1, 1 - (i - 50) * 0.04f);
                bottom_image.color = new Color(1, 1, 1, 1 - (i - 50) * 0.04f);
            }
            yield return waitTime;
        }
        canTouch = true;
        gameObject.SetActive(false);
    }

    private void EndFunc()
    {
        StartCoroutine("EndCour");
    }

    IEnumerator EndCour()
    {
        gameObject.SetActive(true);
        WaitForSeconds waitTime = new WaitForSeconds(fadeSpeed);
        canTouch = false;

        for (int i = 80; i >= 1; i--)
        {
            soundManager.volume = DataManager.Instance.volume_backgroundMusic * i / 80f;

            if (i <= 20)
            {
                all_image.color = new Color(1, 1, 1, 1 - i * 0.05f);
            }
            center.localScale = new Vector3(1, i * 0.032f, 1);
            bottom.localScale = new Vector3(1, 1 - i * 0.024f, 1);
            top.localScale = new Vector3(1, 1 - i * 0.024f + 0.04f, 1);

            if (i >= 40)
            {
                center_image.color = new Color(1, 1, 1, 1 - (i - 50) * 0.04f);
                top_image.color = new Color(1, 1, 1, 1 - (i - 50) * 0.04f);
                bottom_image.color = new Color(1, 1, 1, 1 - (i - 50) * 0.04f);
            }
            yield return waitTime;
        }
    }

    IEnumerator SceneChangeCour(string name)
    {
        StartCoroutine(EndCour());
        yield return new WaitForSeconds(fadeSpeed * 160);
        SceneManager.LoadScene(name);
    }
}
