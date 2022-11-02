using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    
    void Start()
    {
        gameOverCanvas.SetActive(false);
    }
    
    public void GameOver(){
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay(){
        SceneManager.LoadScene(0);
    }
    
}
