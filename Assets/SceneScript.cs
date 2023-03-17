using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    protected bool isGameActive=true;
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }

    public void SetIsGameActive(bool value)
    {
        isGameActive = value;
    }

    public bool GetIsGameActive()
    {
        return isGameActive;
    }

    
}
