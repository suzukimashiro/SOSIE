using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SecondsScene1 : MonoBehaviour
{
    public string nextSceneName = "";

    void Start()
    {
        //何秒後か
        Invoke("ChangeScene", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeScene()
    {
        //遷移先
        SceneManager.LoadScene(nextSceneName);
    }
}