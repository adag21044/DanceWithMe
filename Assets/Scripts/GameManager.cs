using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData gameData;
    public int playerScore = 1;
    
    private void Awake()
    {
        gameData = SaveSystem.Load();
        
    }

    public void GameOver()
    {
        gameData.score += playerScore;
        SaveSystem.Save(gameData);
    }
}
