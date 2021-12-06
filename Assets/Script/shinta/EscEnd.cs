using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Escを押したら
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
