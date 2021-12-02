using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            //オブジェクトを削除します。
            GameObject.Destroy(this.gameObject);

        }
    }
}
