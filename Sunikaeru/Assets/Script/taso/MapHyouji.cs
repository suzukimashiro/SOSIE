using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapHyouji : MonoBehaviour
{
    public GameObject tuijyu;
    public GameObject map;
    public GameObject map2;
    public GameObject player;
    int count = 1;
    
    
    public void Onclick()
    {
        if (count == 1 && player.transform.position.y == 0)//count��1���Aplayer��y���W��0�̎�
        {
            //UeMap Camera���I���̎�
            tuijyu.SetActive(false);
            map.SetActive(true);
            count = 0;
            Debug.Log(count);
        }
        else if (count == 1 && player.transform.position.y <= -0.01)//count��1���Aplayer��y���W��-0.01�ȉ��̎�
        {
            //SitaMap Camera2���I���̎�
            tuijyu.SetActive(false);
            map2.SetActive(true);
            count = 0;
        }
        else if (count == 0)//count��0�̎�
        {
            //Tuijyu Camera���I���̎�
            tuijyu.SetActive(true);
            map.SetActive(false);
            count = 1;
            Debug.Log(count);
        }
    }
}