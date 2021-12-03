using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MolePlayer : MonoBehaviour
{
    Vector3 MOVEX = new Vector3(1f, 0, 0); // x軸方向に１マス移動するときの距離
    Vector3 MOVEZ = new Vector3(0, 0, 1f); // z軸方向に１マス移動するときの距離

    float step = 1f;     // 移動速度
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

    Animator anim;


    
    void Start()
    {
        target = transform.position;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
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
        anim.SetBool("Stoping", true);
        anim.SetBool("Walking", false);

        //右に移動
        if (this.transform.position.x < 10)
        {
            if (rightmove ==true)
            {
                
                target = transform.position + MOVEX;
                kero.y = 90;
                anim.SetBool("Walking", true);
                anim.SetBool("Stoping", false);
            }

            rightmove = false;
        }

        //左に移動
        if (this.transform.position.x > -13)
        {
            if (leftmove == true)
            {
                
                target = transform.position - MOVEX;
                kero.y = 270;
                anim.SetBool("Walking", true);
                anim.SetBool("Stoping", false);
            }

            leftmove = false;
        }

        //上に移動
        if (this.transform.position.z < 10)
        {
            if (forwardmove == true)
            {
                target = transform.position + MOVEZ;
                kero.y = 360;
                anim.SetBool("Walking", true);
                anim.SetBool("Stoping", false);
            }

            forwardmove = false;
        }

        //下に移動
        if (this.transform.position.z > -10)
        {
            if (backmove == true)
            {   
                target = transform.position - MOVEZ;
                kero.y = 180;
                anim.SetBool("Walking", true);
                anim.SetBool("Stoping", false);
            }

            backmove = false;
        }

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

