using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceSeni : MonoBehaviour
{
    //移動するシーンの名前
    public string nextSceneName = "";

    // Update is called once per frame
    private void Update()
    {
        //spaceが押されたとき
        if (Input.GetKeyDown("space"))
        {
            //指定したシーンへ遷移する
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
