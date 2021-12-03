using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    //�����x���ς��X�s�[�h���Ǘ�
    [SerializeField]
    private float fadeSpeed = 0.02f;
    //�p�l���̐F�A�s�����x���Ǘ�
    float red, green, blue, alpha;
    //�o�ߎ��ԃJ�E���g�p
    private float step_time;
    //�t�F�[�h�C�������̊J�n�A�������Ǘ�����t���O
    public bool isFadeIn = false;
    //�����x��ύX����p�l���̃C���[�W
    Image fadeImage;

    // Start is called before the first frame update
    void Start()
    {
        //�o�ߎ��ԏ�����
        step_time = 0.0f;
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;   //��
        green = fadeImage.color.g; //��
        blue = fadeImage.color.b;  //��
        alpha = fadeImage.color.a; //�s�����x
    }
    // Update is called once per frame
    void Update()
    {
        step_time += Time.deltaTime;
        if (step_time >= 0.0f)
        {
            alpha -= fadeSpeed;            //�s�����x�����X�ɉ�����
            SetAlpha();                    //�ύX�����s�����x�p�l���ɔ��f����
            if (alpha <= 0)
            {                              //���S�ɓ����ɂȂ����珈���𔲂���
                isFadeIn = false;
                fadeImage.enabled = false; //�p�l���̕\�����I�t�ɂ���
            }
        }
    }
    void SetAlpha()
    {
        //�ύX���ꂽcolor�𔽉f����
        fadeImage.color = new Color(red, green, blue, alpha);
    }
}
