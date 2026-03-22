using System;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public LevelManager levelManager;
    public BrickManager brickManager;
    public Player player;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            LoadNextLevel();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LoadPreviousLevel();
        }
    }

   
    private void LoadNextLevel()
    {
        levelManager.curLevelNo +=1;
        RestartLevel();
    }
    private void LoadPreviousLevel()
    {
        levelManager.curLevelNo = Mathf.Max(levelManager.curLevelNo - 1,1);
        RestartLevel();
    }

    void RestartLevel() 
    {
        Debug.Log("Restart Level");

        levelManager.RestartLevelManager();
        brickManager.RestartBrickManager();
        player.RestartPlayer();
    }
}
