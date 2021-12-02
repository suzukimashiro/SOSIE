using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
    //�����x���ς��X�s�[�h���Ǘ�
    [SerializeField]
    private float fadeSpeed = 0.02f;
    //�p�l���̐F�A�s�����x���Ǘ�
    float red, green, blue, alpha;
    //�o�ߎ��ԃJ�E���g�p
    private float step_time;
    //�t�F�[�h�C�������̊J�n�A�������Ǘ�����t���O
    public bool isFadeOut = false;
    //�����x��ύX����p�l���̃C���[�W
    Image fadeImage;
    //�J�ڐ�̖��O���w��
    [SerializeField]
    private string nextSceneName = "";

    // Start is called before the first frame update
    void Start()
    {
        step_time = 0.0f;�@�@�@�@  //�o�ߎ��ԏ�����
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
            alpha += fadeSpeed; //�s�����x�����X�ɂ�����
            SetAlpha();         //�ύX���������x���p�l���ɔ��f����
            if (alpha >= 1)
            {                   //���S�ɕs�����ɂȂ����珈���𔲂���
                isFadeOut = false;
                //�w�肵��Scene�ɑJ��
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
    void SetAlpha()
    {
        //�ύX���ꂽcolor�𔽉f����
        fadeImage.color = new Color(red, green, blue, alpha);
    }
}