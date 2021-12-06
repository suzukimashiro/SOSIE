using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerCon : MonoBehaviour
{
    [SerializeField] private DataServer server;
    [SerializeField] private Vector3Int pos;

    bool forwardmove;
    bool backmove;
    bool rightmove;
    bool leftmove;

    [SerializeField]
    private Vector3 velocity;
    Vector3 kero = new Vector3();

    private void Update()
    {
        //��ړ�
        if (forwardmove == true)
        {
            if (server.stageData.ToArray()[pos.y - 1].ToArray()[pos.x] == 10)
            { return; }
            pos.y--;
            kero.y = 270;
        }
        forwardmove = false;

        //���ړ�
        if (backmove == true)
        {
            if (server.stageData.ToArray()[pos.y + 1].ToArray()[pos.x] == 9)
            { return; }
            pos.y++;
            kero.y = 90;
        }
        backmove = false;

        //�E�ړ�
        if (rightmove == true)
        {
            if (server.stageData.ToArray()[pos.y].ToArray()[pos.x + 1] == 8)
            { return; }
            pos.x++;
            kero.y = 360;
        }
        rightmove = false;

        //���ړ�
        if (leftmove == true)
        {
            if (server.stageData.ToArray()[pos.y].ToArray()[pos.x - 1] == 7)
            { return; }
            pos.x--;
            kero.y = 180;
        }
        leftmove = false;


        this.transform.position = new Vector3(pos.y, 0, pos.x);

        ////playerPos�ϐ���x��y�ɐ��������l������
        ////playerPos.x�Ƃ����l��-playerPosXClamp�`playerPosXClamp�̊ԂɎ��߂�     
        gameObject.transform.eulerAngles = kero;


        //�����ꂩ�̕����Ɉړ����Ă���ꍇ
        if (velocity.magnitude > 0)
        {
            transform.position += velocity;
        }

    }


    public void ForwardButtonDown() => forwardmove = true;
    public void ForwardButtonUp() => forwardmove = false;
    public void BackButtonDown() => backmove = true;
    public void BackButtonUp() => backmove = false;
    public void RightButtonDown() => rightmove = true;
    public void RightButtonUp() => rightmove = false;
    public void LeftButtonDown() => leftmove = true;
    public void LeftButtonUp() => leftmove = false;
}


