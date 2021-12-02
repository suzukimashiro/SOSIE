using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchSeni : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Bomb")
        {

            SceneManager.LoadScene("GameOver");

        }
        if (other.gameObject.tag == "Goal")

        {

            SceneManager.LoadScene("GameClear");

        }

    }

}
