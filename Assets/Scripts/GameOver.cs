using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public static GameOver instance;
    public GameObject gameOverPanel;
    public TMP_Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void endGame() {
        instance.gameOverPanel.SetActive(true);
        instance.text.text = "Score: " + ScoreKeeper.instance.cur;
    }

    public void restart() {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
