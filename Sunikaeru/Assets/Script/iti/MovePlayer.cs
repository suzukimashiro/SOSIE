using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private Vector3 velocity;
    [SerializeField]
    private float speed = 1.0f;

    Vector3 kero = new Vector3();

    private Animator animator;
    Rigidbody rb;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        velocity = Vector3.zero;
        animator.SetBool("Walks", false);
        animator.SetBool("idles", true);



        //上に移動
        if (Input.GetKey(KeyCode.W))
        {
            velocity.z += 1;
            animator.SetBool("Walks", true);
            animator.SetBool("idles", false);
            kero.y = 360;
        }

        //下に移動     
        if (Input.GetKey(KeyCode.S))
        {
            velocity.z -= 1;
            animator.SetBool("Walks", true);
            animator.SetBool("idles", false);
            kero.y = 180;
        }

        //右に移動
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x += 1;
            animator.SetBool("Walks", true);
            animator.SetBool("idles", false);
            kero.y = 90;
        }

        //左に移動
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x -= 1;
            animator.SetBool("Walks", true);
            animator.SetBool("idles", false);
            kero.y = 270;
        }

        gameObject.transform.eulerAngles = kero;


        //速度ベクトルの長さを1秒でspeedだけ進むように調整する
        velocity = velocity.normalized * speed * Time.deltaTime;

        //いずれかの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            transform.position += velocity;
        }
    }
}
