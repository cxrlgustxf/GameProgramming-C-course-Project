using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


     void Awake()
    {
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        SceneManager.UnloadSceneAsync("PauseMenu");
    }

    public void MainMenu()
    {
        if (EventsUI.Score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", EventsUI.Score);
        }
        SceneManager.LoadScene("MainMenu");

    }



}
