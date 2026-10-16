using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void MainMenu()
    {
        if (EventsUI.Score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", EventsUI.Score);
        }
        SceneManager.LoadScene("MainMenu");

    }
    public void QuitGame()
    {
        if (EventsUI.Score > PlayerPrefs.GetInt("HighScore")){
            PlayerPrefs.SetInt("HighScore", EventsUI.Score);
        }
       
        Application.Quit();
        
    }

    
}
