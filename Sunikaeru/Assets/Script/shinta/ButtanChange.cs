using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtanChange : MonoBehaviour
{
    //遷移先の名前を指定
    [SerializeField]
    private string nextSceneName = "";  

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Touch()
    {
        //指定したSceneに遷移
        SceneManager.LoadScene(nextSceneName);
    }
}