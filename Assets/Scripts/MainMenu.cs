using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Update()
    {
        if(Input.GetMouseButton(0))
        {
            PlayGame();
        }
        else
        if(Input.touchCount > 0 )
        {
            PlayGame();
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");

    }
}
