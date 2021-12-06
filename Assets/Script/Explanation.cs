using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explanation : MonoBehaviour
{
 //　ポーズした時に表示するUI
	[SerializeField]
	private GameObject pauseUI;



    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown ("q")) {
			//　ポーズUIのアクティブ、非アクティブを切り替え
			pauseUI.SetActive (!pauseUI.activeSelf);

            //　ポーズUIが表示されてる時は停止
            if (pauseUI.activeSelf)
            {
                Pauser.Pause();
                Time.timeScale = 0f;
   
            }
            else
            {
                Pauser.Resume();
                Time.timeScale = 1f;

            }
		}
	}
}
