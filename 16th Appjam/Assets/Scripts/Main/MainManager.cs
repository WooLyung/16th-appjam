using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour {

    GameObject optionsWindow;
    Option option;

    private void Awake()
    {
        optionsWindow = GameObject.Find("Canvas").transform.Find("OptionsWindow").gameObject;
        option = GameObject.Find("Options").GetComponent<Option>();

        DataManager.Instance.isClear_stage1 = 0;
        DataManager.Instance.isClear_stage2 = 0;
        DataManager.Instance.isClear_stage3 = 0;
        DataManager.Instance.isClear_stage4 = 0;
        DataManager.Instance.memorySlice = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (optionsWindow.activeSelf == false)
                Application.Quit();
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (optionsWindow.activeSelf == false && option.isEnterOption == false)
                ChangeScene.Instance.SceneChange("Stage");
        }
    }
}
