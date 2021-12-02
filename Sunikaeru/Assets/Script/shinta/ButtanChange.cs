using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtanChange : MonoBehaviour
{
    //‘JˆÚæ‚Ì–¼‘O‚ğw’è
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
        //w’è‚µ‚½Scene‚É‘JˆÚ
        SceneManager.LoadScene(nextSceneName);
    }
}