using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GameScene()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
