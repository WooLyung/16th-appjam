using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour {

    GameObject optionsWindow;

    Slider soundEffect;
    Slider backgroundMusic;

    public bool isEnterOption = false;

    private void Start()
    {
        optionsWindow = GameObject.Find("Canvas").transform.Find("OptionsWindow").gameObject;
        soundEffect = optionsWindow.transform.Find("SoundEffect").Find("Slider").GetComponent<Slider>();
        backgroundMusic = optionsWindow.transform.Find("BackgroundMusic").Find("Slider").GetComponent<Slider>();

        soundEffect.value = DataManager.Instance.volume_soundEffect * 10;
        backgroundMusic.value = DataManager.Instance.volume_backgroundMusic * 10;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (optionsWindow.activeSelf == true)
                optionsWindow.SetActive(false);
        }
    }

    public void Options()
    {
        if (optionsWindow.activeSelf == false)
            optionsWindow.SetActive(true);
    }

    public void EnterOption()
    {
        isEnterOption = true;
    }

    public void ExitOption()
    {
        isEnterOption = false;
    }

    public void SetValue_SoundEffect()
    {
        DataManager.Instance.volume_soundEffect = soundEffect.value / 10f;
    }

    public void SetValue_BackgroundMusic()
    {
        DataManager.Instance.volume_backgroundMusic = backgroundMusic.value / 10f;
    }
}