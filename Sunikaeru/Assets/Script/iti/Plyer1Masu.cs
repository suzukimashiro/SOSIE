using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plyer1Masu : MonoBehaviour
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






    // Use this for initialization
    void Start()
    {
        target = transform.position;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
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

            if (this.transform.position.x < 3f)
            {
                if (Input.GetKey(KeyCode.D))
                {
                    //rb.velocity = MOVEX;
                    target = transform.position + MOVEX;
                    kero.y = 90;
                }
            }

            if (this.transform.position.x > -5)
            {
                if (Input.GetKey(KeyCode.A))
                {
                    //rb.velocity = -MOVEX;
                    target = transform.position - MOVEX;
                    kero.y = 270;
                }
            }

            if (this.transform.position.z < 13)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    //rb.velocity = MOVEZ;
                    target = transform.position + MOVEZ;
                    kero.y = 360;
                }
            }

            if (this.transform.position.z > -4)
            {
                if (Input.GetKey(KeyCode.S))
                {
                    //rb.velocity = -MOVEZ;
                    target = transform.position - MOVEZ;
                    kero.y = 180;


                }
            }



            ////playerPos変数のxとyに制限した値を入れる
            ////playerPos.xという値を-playerPosXClamp～playerPosXClampの間に収める
            //this.target.x = Mathf.Clamp(this.target.x, -this.playerPosX2Clamp, this.playerPosXClamp);
            //this.target.z = Mathf.Clamp(this.target.z, -this.playerPosZ2Clamp, this.playerPosZClamp);

            //transform.position = new Vector3(this.target.x, this.target.y, this.target.z);

            gameObject.transform.eulerAngles = kero;



            //いずれかの方向に移動している場合
            if (velocity.magnitude > 0)
            {
                transform.position += velocity;
            }


        }
    

    


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
