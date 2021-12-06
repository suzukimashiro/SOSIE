using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float time;
    //タイムのテキスト指定場所
    public Text TimeText;
    //imageの指定場所
    public GameObject image;
    //目標スコアの設定場所
    [SerializeField]
    private int timescore;

    void Start()
    {
        time = 0.0f;
    }

    void Update()
    {
        //時間経過
        time += Time.deltaTime;
        //タイムを小数点第1まで表示する("F")の後の数字で変わる
        TimeText.text = time.ToString("F1");
    }
    //当たり判定
    private void OnCollisionEnter(Collision collision)
    {
        //タグの指定
        string Tag = collision.gameObject.tag;
        if (Tag == "Goal")
        {
            //timeがtimescore以下だったら
            if(time <= timescore)
            {
                //imageを表示
                image.SetActive(true);
            }
        }
    }
}
