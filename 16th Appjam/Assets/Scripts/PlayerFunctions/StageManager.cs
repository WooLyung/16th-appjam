using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageManager : MonoBehaviour {

    public Text confirm;

    public void Confirm()
    {
        if (confirm.text == "영화관" && DataManager.Instance.isClear_stage1 == 0)
        {
            SceneManager.LoadScene("Animation1");
        }
        if (confirm.text == "가로수길" && DataManager.Instance.isClear_stage2 == 0)
        {
            SceneManager.LoadScene("Animation2");
        }
        if (confirm.text == "바다" && DataManager.Instance.isClear_stage3 == 0)
        {
            SceneManager.LoadScene("Animation3");
        }
        if (confirm.text == "집" && DataManager.Instance.isClear_stage4 == 0)
        {
            //SceneManager.LoadScene("Animation4");
        }
    }
}
