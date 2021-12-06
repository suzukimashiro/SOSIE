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
        //ãˆÚ“®
        if (forwardmove == true)
        {
            if (server.stageData.ToArray()[pos.y - 1].ToArray()[pos.x] == 10)
            { return; }
            pos.y--;
            kero.y = 270;
        }
        forwardmove = false;

        //‰ºˆÚ“®
        if (backmove == true)
        {
            if (server.stageData.ToArray()[pos.y + 1].ToArray()[pos.x] == 9)
            { return; }
            pos.y++;
            kero.y = 90;
        }
        backmove = false;

        //‰EˆÚ“®
        if (rightmove == true)
        {
            if (server.stageData.ToArray()[pos.y].ToArray()[pos.x + 1] == 8)
            { return; }
            pos.x++;
            kero.y = 360;
        }
        rightmove = false;

        //¶ˆÚ“®
        if (leftmove == true)
        {
            if (server.stageData.ToArray()[pos.y].ToArray()[pos.x - 1] == 7)
            { return; }
            pos.x--;
            kero.y = 180;
        }
        leftmove = false;


        this.transform.position = new Vector3(pos.y, 0, pos.x);

        ////playerPos•Ï”‚Ìx‚Æy‚É§ŒÀ‚µ‚½’l‚ð“ü‚ê‚é
        ////playerPos.x‚Æ‚¢‚¤’l‚ð-playerPosXClamp`playerPosXClamp‚ÌŠÔ‚ÉŽû‚ß‚é     
        gameObject.transform.eulerAngles = kero;


        //‚¢‚¸‚ê‚©‚Ì•ûŒü‚ÉˆÚ“®‚µ‚Ä‚¢‚éê‡
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


