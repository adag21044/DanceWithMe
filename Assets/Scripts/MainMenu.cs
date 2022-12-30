using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      RaycastHit hit;  
      if (Physics.Raycast(ray, out hit)) {  
        //Select stage    
        if (hit.transform.name == "Play Button") {  
          SceneManager.LoadScene("Shop"); */
    public GameData gameData;
    public Button button;
    private void Awake()
    {
        gameData = SaveSystem.Load();
        
    }
    public void Update()
    {
   
        if(Input.GetButtonDown("button"))
        {
            PlayGame();
        }
        else
        if(Input.GetMouseButton(1))
        {
            ShopMenu();
            Debug.Log("Shop");
        }
       
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");

    }

    public void ShopMenu()
    {
        SceneManager.LoadScene("Shop menu");
    }
}
