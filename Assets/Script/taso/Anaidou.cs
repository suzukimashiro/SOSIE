using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anaidou : MonoBehaviour
{
    
        void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.tag == "Ana")

            {

                transform.position = new Vector3(-5, -47, -4);
                Debug.Log("ana");
            }

        }
    
}
