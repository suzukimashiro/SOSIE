using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float time;
    //�^�C���̃e�L�X�g�w��ꏊ
    public Text TimeText;
    //image�̎w��ꏊ
    public GameObject image;
    //�ڕW�X�R�A�̐ݒ�ꏊ
    [SerializeField]
    private int timescore;

    void Start()
    {
        time = 0.0f;
    }

    void Update()
    {
        //���Ԍo��
        time += Time.deltaTime;
        //�^�C���������_��1�܂ŕ\������("F")�̌�̐����ŕς��
        TimeText.text = time.ToString("F1");
    }
    //�����蔻��
    private void OnCollisionEnter(Collision collision)
    {
        //�^�O�̎w��
        string Tag = collision.gameObject.tag;
        if (Tag == "Goal")
        {
            //time��timescore�ȉ���������
            if(time <= timescore)
            {
                //image��\��
                image.SetActive(true);
            }
        }
    }
}
