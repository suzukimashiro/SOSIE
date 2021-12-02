using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHakai : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //オブジェクトを非表示にします。
            this.gameObject.SetActive(false);

        }
    }

}

