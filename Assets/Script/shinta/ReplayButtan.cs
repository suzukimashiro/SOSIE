using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReplayButtan : MonoBehaviour
{
    //panel�̎w��ꏊ
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Replay()
    {
        // ���݂�Scene�����擾����
        Scene loadScene = SceneManager.GetActiveScene();
        // Scene�̓ǂݒ���
        SceneManager.LoadScene(loadScene.name);
    }

    //�����蔻��
    private void OnCollisionEnter(Collision collision)
    {
        //�^�O���t�����I�u�W�F�N�g������������
        if (collision.gameObject.tag == "Test")
        {
            //�\������
            panel.SetActive(true);
        }

    }
}
