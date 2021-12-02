using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomAreat : MonoBehaviour
{

    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;

    AudioSource audioSource;

    private void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Bomb")
        {
            audioSource.PlayOneShot(sound1);
        }

        else
        {
            audioSource.PlayOneShot(sound2);
        }
    }
}
