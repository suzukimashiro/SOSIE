using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountUp : MonoBehaviour
{
    //Text�p�ϐ�
    public Text scoreText;
    //�X�R�A�v�Z�p�ϐ�
    private int score = 0;
    public GameObject image;
    //Score�̎w��
    [SerializeField]
    private int ScoreKijun;
    void Start()
    {
        //�����X�R�A�������ĕ\��
        score = 0;
        SetScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�����蔻��
    void OnCollisionEnter(Collision collision)
    {
        //�^�O�̎w��
        string Tag = collision.gameObject.tag;
        //�^�O"Cube"�����Ă��
        if (Tag == "Cube")
        {
            //Score�̉��Z
            score += 1;
        }
        //����ȊO
        else
        {
            //Score�̉��Z
            score += 10;
        }
        //Score��"50"�������
        if (score == ScoreKijun)
        {
            //Image�̕\��
            image.SetActive(true);
        }
        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score);
    }
}