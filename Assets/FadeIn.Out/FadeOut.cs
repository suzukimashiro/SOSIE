using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
    //透明度が変わるスピードを管理
    [SerializeField]
    private float fadeSpeed = 0.02f;
    //パネルの色、不透明度を管理
    float red, green, blue, alpha;
    //経過時間カウント用
    private float step_time;
    //フェードイン処理の開始、完了を管理するフラグ
    public bool isFadeOut = false;
    //透明度を変更するパネルのイメージ
    Image fadeImage;
    //遷移先の名前を指定
    [SerializeField]
    private string nextSceneName = "";

    // Start is called before the first frame update
    void Start()
    {
        step_time = 0.0f;　　　　  //経過時間初期化
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;   //赤
        green = fadeImage.color.g; //緑
        blue = fadeImage.color.b;  //青
        alpha = fadeImage.color.a; //不透明度
    }

    // Update is called once per frame
    void Update()
    {
        step_time += Time.deltaTime;
        if (step_time >= 0.0f)
        {
            alpha += fadeSpeed; //不透明度を徐々にあげる
            SetAlpha();         //変更した透明度をパネルに反映する
            if (alpha >= 1)
            {                   //完全に不透明になったら処理を抜ける
                isFadeOut = false;
                //指定したSceneに遷移
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
    void SetAlpha()
    {
        //変更されたcolorを反映する
        fadeImage.color = new Color(red, green, blue, alpha);
    }
}