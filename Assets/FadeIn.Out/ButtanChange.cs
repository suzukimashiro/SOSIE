using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtanChange : MonoBehaviour
{
    [SerializeField]
    private string nextSceneName = "";  //�J�ڐ�̖��O���w��

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
        //�w�肵��Scene�ɑJ��
        SceneManager.LoadScene(nextSceneName);
    }
}