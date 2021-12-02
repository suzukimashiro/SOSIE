using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotanSeni1 : MonoBehaviour
{
    //移動するシーンの名前
    public string nextSceneName = "";

    public void OnClickStartButton()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}