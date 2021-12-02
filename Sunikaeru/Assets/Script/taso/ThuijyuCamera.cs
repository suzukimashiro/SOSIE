using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThuijyuCamera : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //�v���C���[�̏����擾
        this.player = GameObject.Find("Player");

        //���C���J�����ƃv���C���[�Ƃ̋��������߂�
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //�V�����g�����X�t�H�[���̒l����
        transform.position = player.transform.position + offset;
    }
}
