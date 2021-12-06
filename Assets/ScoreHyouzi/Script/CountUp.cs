using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountUp : MonoBehaviour
{
    //Text用変数
    public Text scoreText;
    //スコア計算用変数
    private int score = 0;
    //imageの指定場所
    public GameObject image;
    //目標Scoreの設定場所
    [SerializeField]
    private int scoremokuhyo;
    //宝に当たった時の加算設定場所
    [SerializeField]
    private int takarascore;
    //土に当たった時の加算設定場所
    [SerializeField]
    private int blockscore;

    void Start()
    {
        //初期スコアを代入して表示
        score = 0;
        SetScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //当たり判定
    void OnCollisionEnter(Collision collision)
    {
        //タグの指定
        string Tag = collision.gameObject.tag;
        //タグ"Cube"がついてると
        if (Tag == "Block")
        {
            //Scoreの加算
            score += blockscore;
        }
        //それ以外
        else
        {
            //Scoreの加算
            score += takarascore;
        }

        //ScoreがScoreMokuhyo以上取ったら
        if (score >= scoremokuhyo)
        {
            //Imageの表示
            image.SetActive(true);
        }
        //タグ"Bomb"がついてると
        if (Tag == "Bomb")
        {
            //スコアの初期化
            score = 0;
            //imageの非表示
            image.SetActive(false);
        }
        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score);
    }
}