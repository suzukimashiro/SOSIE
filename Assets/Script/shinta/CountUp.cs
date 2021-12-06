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
    //image�̎w��ꏊ
    public GameObject image;
    //�ڕWScore�̐ݒ�ꏊ
    [SerializeField]
    private int ScoreMokuhyo;
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

        //Score��ScoreMokuhyo�ȏ�������
        if (score >= ScoreMokuhyo)
        {
            //Image�̕\��
            image.SetActive(true);
        }
        //�^�O"Bomb"�����Ă��
        if (Tag == "Bomb")
        {
            //�X�R�A�̏�����
            score = 0;
            //image�̔�\��
            image.SetActive(false);
        }

        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score);
    }
}