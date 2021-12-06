using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MolePlayer : MonoBehaviour
{
    Vector3 MOVEX = new Vector3(1f, 0, 0); // x軸方向に１マス移動するときの距離
    Vector3 MOVEZ = new Vector3(0, 0, 1f); // z軸方向に１マス移動するときの距離

    float step = 2f;     // 移動速度
    Vector3 target;      // 入力受付時、移動後の位置を算出して保存 
    Vector3 prevPos;     // 何らかの理由で移動できなかった場合、元の位置に戻すため移動前の位置を保存
    Rigidbody rb;
    [SerializeField]
    private Vector3 velocity;
    Vector3 kero = new Vector3();

    //ボタン(上下左右)
    bool forwardmove;
    bool backmove;
    bool rightmove;
    bool leftmove;

    GameObject Player;
    GameObject wall_Left;
    GameObject wall_Right;
    GameObject wall_Bottom;
    GameObject wall_Top;

    void Start()
    {
        target = transform.position;
        rb = GetComponent<Rigidbody>();

        Player = GameObject.Find("Player");
        wall_Left = GameObject.Find("Wall Left(Clone)");
        wall_Right = GameObject.Find("Wall Right(Clone)");
        wall_Bottom = GameObject.Find("Wall Bottom(Clone)");
        wall_Top = GameObject.Find("Wall Top(Clone)");

    }


    void Update()
    {


        // ① 移動中かどうかの判定。移動中でなければ入力を受付
        if (transform.position == target)
        {
            SetTargetPosition();
        }

        Move();
    }

    // ② 入力に応じて移動後の位置を算出
    void SetTargetPosition()
    {
        prevPos = target;

        //右に移動
        //if (this.transform.position.x  < 3) //

        
            if (rightmove == true)
            {
                target = transform.position + MOVEZ;
                kero.y = 360;
                
            }

            rightmove = false;
        

        //左に移動
       // if (this.transform.position.x > -5)
        {
            if (leftmove == true)
            {
                //Debug.Log(area.GetComponent<Kabe>().lkabe);
                target = transform.position - MOVEZ;
                kero.y = 180;
            }

            leftmove = false;
        }

        //上に移動
       // if (this.transform.position.z < 13)
        {
            if (forwardmove == true)
            {
                Debug.Log("desu");
                target = transform.position + MOVEX;
                kero.y = 270;
            }

            forwardmove = false;
        }

        //下に移動
       // if (this.transform.position.z > -4)
        {
            if (backmove == true)
            {   
                target = transform.position - MOVEX;
                kero.y = 90;
            }

            backmove = false;
        }

        Player.transform.position = new
      Vector3(Mathf.Clamp(Player.transform.position.x, wall_Left.transform.position.x, wall_Right.transform.position.x),
       Player.transform.position.y,
        Mathf.Clamp(Player.transform.position.z, wall_Bottom.transform.position.z, wall_Top.transform.position.z));

        ////playerPos変数のxとyに制限した値を入れる
        ////playerPos.xという値を-playerPosXClamp～playerPosXClampの間に収める     
        gameObject.transform.eulerAngles = kero;

        //いずれかの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            transform.position += velocity;
        }
    }

    //ボタンが押されているかor離されているか
    public void forwardButtonDown() => forwardmove = true;
    public void forwardButtonUp() => forwardmove = false;
    public void backButtonDown() => backmove = true;
    public void backButtonUp() => backmove = false;
    public void rightButtonDown() => rightmove = true;
    public void rightButtonUp() => rightmove = false;
    public void leftButtonDown() => leftmove = true;
    public void leftButtonUp() => leftmove = false;




    // ③ 目的地へ移動する
    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, step * Time.deltaTime);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Block")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}

