using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button playButton;
    [SerializeField] Button quitButton;

    [SerializeField] TextMeshProUGUI HighScore;
    
    void Awake()
    {
        Time.timeScale = 1f;
        playButton.onClick.AddListener(StartGame);
        quitButton.onClick.AddListener(QuitGame);
        HighScore.text = "Current High score: " + PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }

    void QuitGame()
    {
        Application.Quit();
        
    }


    
}
