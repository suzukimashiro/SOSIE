using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButtan : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Replay()
    {
        // 現在のScene名を取得する
        Scene loadScene = SceneManager.GetActiveScene();
        // Sceneの読み直し
        SceneManager.LoadScene(loadScene.name);
    }

    //当たり判定
    private void OnCollisionEnter(Collision collision)
    {
        //タグが付いたオブジェクトが当たったら
        if (collision.gameObject.tag == "Test")
        {
            //表示判定
            panel.SetActive(true);
        }

    }
}
