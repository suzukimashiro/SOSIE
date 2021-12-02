using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerCon : MonoBehaviour
{
    [SerializeField] private DataServer server;
    [SerializeField] private Vector2Int pos;
    bool forwardmove;
    bool backmove;
    bool rightmove;
    bool leftmove;



    private void Update()
    {
        if (forwardmove == true)
        {
            if (server.stageData.ToArray()[pos.y - 1].ToArray()[pos.x] == 10)
            { return; }
            pos.y--;
        }
        forwardmove = false;


        if (backmove == true)
        {
            if (server.stageData.ToArray()[pos.y + 1].ToArray()[pos.x] == 9)
            { return; }
            pos.y++;
        }
        backmove = false;


        if (rightmove == true)
        {
            if (server.stageData.ToArray()[pos.y].ToArray()[pos.x + 1] == 8)
            { return; }
            pos.x++;
        }
        rightmove = false;


        if (leftmove == true)
        {
            if (server.stageData.ToArray()[pos.y].ToArray()[pos.x - 1] == 7)
            { return; }
            pos.x--;
        }
        leftmove = false;


        this.transform.position = new Vector3(pos.y, 0, pos.x);

        
    }
    

    public void forwardButtonDown() => forwardmove = true;
    public void forwardButtonUp() => forwardmove = false;
    public void backButtonDown() => backmove = true;
    public void backButtonUp() => backmove = false;
    public void rightButtonDown() => rightmove = true;
    public void rightButtonUp() => rightmove = false;
    public void leftButtonDown() => leftmove = true;
    public void leftButtonUp() => leftmove = false;
}


