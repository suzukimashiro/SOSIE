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
        if (count == 1 && player.transform.position.y == 0)//countが1かつ、playerのy座標が0の時
        {
            //UeMap Cameraがオンの時
            tuijyu.SetActive(false);
            map.SetActive(true);
            count = 0;
            Debug.Log(count);
        }
        else if (count == 1 && player.transform.position.y <= -0.01)//countが1かつ、playerのy座標が-0.01以下の時
        {
            //SitaMap Camera2がオンの時
            tuijyu.SetActive(false);
            map2.SetActive(true);
            count = 0;
        }
        else if (count == 0)//countが0の時
        {
            //Tuijyu Cameraがオンの時
            tuijyu.SetActive(true);
            map.SetActive(false);
            count = 1;
            Debug.Log(count);
        }
    }
}