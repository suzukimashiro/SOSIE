using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    //透明度が変わるスピードを管理
    [SerializeField]
    private float fadeSpeed = 0.02f;
    //パネルの色、不透明度を管理
    float red, green, blue, alpha;
    //経過時間カウント用
    private float step_time;
    //フェードイン処理の開始、完了を管理するフラグ
    public bool isFadeIn = false;
    //透明度を変更するパネルのイメージ
    Image fadeImage;

    // Start is called before the first frame update
    void Start()
    {
        //経過時間初期化
        step_time = 0.0f;
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
            alpha -= fadeSpeed;            //不透明度を徐々に下げる
            SetAlpha();                    //変更した不透明度パネルに反映する
            if (alpha <= 0)
            {                              //完全に透明になったら処理を抜ける
                isFadeIn = false;
                fadeImage.enabled = false; //パネルの表示をオフにする
            }
        }
    }
    void SetAlpha()
    {
        //変更されたcolorを反映する
        fadeImage.color = new Color(red, green, blue, alpha);
    }
}
