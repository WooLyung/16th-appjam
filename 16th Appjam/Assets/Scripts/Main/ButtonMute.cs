using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMute : MonoBehaviour
{
    public enum Kind { SoundEffect, BackgroundMusic }

    public Kind kind;
    public Sprite Mute;
    public Sprite Volume;

    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
        GetComponent<Button>().onClick.AddListener(OnClickButtonMute);
    }

    private void OnClickButtonMute()
    {
        if (kind == Kind.SoundEffect)
        {
            DataManager.Instance.soundEffectMute = !DataManager.Instance.soundEffectMute;

            if (DataManager.Instance.soundEffectMute == false)
            {
                image.sprite = Volume;
            }
            else
            {
                image.sprite = Mute;
            }
        }
        else
        {
            DataManager.Instance.backgroundMusicMute = !DataManager.Instance.backgroundMusicMute;

            if (DataManager.Instance.backgroundMusicMute == false)
            {
                GameObject.Find("SoundManager").GetComponent<AudioSource>().mute = false;
                image.sprite = Volume;
            }
            else
            {
                GameObject.Find("SoundManager").GetComponent<AudioSource>().mute = true;
                image.sprite = Mute;
            }
        }
    }
}
