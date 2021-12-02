using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThuijyuCamera : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーの情報を取得
        this.player = GameObject.Find("Player");

        //メインカメラとプレイヤーとの距離を求める
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //新しいトランスフォームの値を代入
        transform.position = player.transform.position + offset;
    }
}
