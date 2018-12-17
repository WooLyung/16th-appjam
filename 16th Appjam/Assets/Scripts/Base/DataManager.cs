using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour {

    public static DataManager Instance;
    public static int count = 0;
    
    public float _volume_soundEffect;
    public float _volume_backgroundMusic;
    public int _isClear_stage1;
    public int _isClear_stage2;
    public int _isClear_stage3;
    public int _isClear_stage4;
    public int _memorySlice;

    public bool soundEffectMute;
    public bool backgroundMusicMute;

    public float volume_soundEffect
    {
        get
        {
            return _volume_soundEffect;
        }
        set
        {
            _volume_soundEffect = value;
            PlayerPrefs.SetFloat("volume_soundEffect", value);
        }
    }

    public float volume_backgroundMusic
    {
        get
        {
            return _volume_backgroundMusic;
        }
        set
        {
            _volume_backgroundMusic = value;
            PlayerPrefs.SetFloat("volume_backgroundMusic", value);
            SoundManager.Instance.audioSource.volume = value;
        }
    }

    public int isClear_stage1
    {
        get
        {
            return _isClear_stage1;
        }
        set
        {
            _isClear_stage1 = value;
            PlayerPrefs.SetInt("isClear_stage1", value);
        }
    }

    public int isClear_stage2
    {
        get
        {
            return _isClear_stage2;
        }
        set
        {
            _isClear_stage2 = value;
            PlayerPrefs.SetInt("isClear_stage2", value);
        }
    }
    
    public int isClear_stage3
    {
        get
        {
            return _isClear_stage3;
        }
        set
        {
            _isClear_stage3 = value;
            PlayerPrefs.SetInt("isClear_stage3", value);
        }
    }

    public int isClear_stage4
    {
        get
        {
            return _isClear_stage4;
        }
        set
        {
            _isClear_stage4 = value;
            PlayerPrefs.SetInt("isClear_stage4", value);
        }
    }

    public int memorySlice
    {
        get
        {
            return _memorySlice;
        }
        set
        {
            _memorySlice = value;
            PlayerPrefs.SetInt("memorySlice", value);
        }
    }

    private void Awake()
    {
        Instance = this;

        if (!PlayerPrefs.HasKey("volume_soundEffect"))
        {
            _volume_soundEffect = 0.6f;
            PlayerPrefs.SetFloat("volume_soundEffect", 0.6f);
        }
        if (!PlayerPrefs.HasKey("volume_backgroundMusic"))
        {
            _volume_backgroundMusic = 0.6f;
            PlayerPrefs.SetFloat("volume_backgroundMusic", 0.6f);
        }

        _isClear_stage1 = PlayerPrefs.GetInt("isClear_stage1");
        _isClear_stage2 = PlayerPrefs.GetInt("isClear_stage2");
        _isClear_stage3 = PlayerPrefs.GetInt("isClear_stage3");
        _isClear_stage4 = PlayerPrefs.GetInt("isClear_stage4");
        _memorySlice = PlayerPrefs.GetInt("memorySlice");
        _volume_soundEffect = PlayerPrefs.GetFloat("volume_soundEffect");
        _volume_backgroundMusic = PlayerPrefs.GetFloat("volume_backgroundMusic");
    }
}
