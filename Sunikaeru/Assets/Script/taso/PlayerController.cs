using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private DataServer server;
    [SerializeField] private Vector2Int pos;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if(server.stageData.ToArray()[pos.y - 1].ToArray()[pos.x] == 7)
            { return; }
            pos.y--;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (server.stageData.ToArray()[pos.y + 1].ToArray()[pos.x] == 7)
            { return; }
            pos.y++;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (server.stageData.ToArray()[pos.y].ToArray()[pos.x + 1] == 7)
            { return; }
            pos.x++;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (server.stageData.ToArray()[pos.y].ToArray()[pos.x - 1] == 7)
            { return; }
            pos.x--;
        }

        this.transform.position = new Vector3(pos.y, 0, pos.x);
    }
}
