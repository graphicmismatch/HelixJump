using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    int hs;
    public int cur = 0;
    public TMP_Text score;
    public TMP_Text highscore;
    public static ScoreKeeper instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
        if (!PlayerPrefs.HasKey("hs"))
        {
           PlayerPrefs.SetInt("hs",0);
        }

        hs = PlayerPrefs.GetInt("hs");
    }

    // Update is called once per frame
    void Update()
    {
        cur = Mathf.FloorToInt(Mathf.Abs(transform.position.y) / HelixGenerator.hg.platformSpacing);
        if (cur > hs)
        {
            hs = cur;
            PlayerPrefs.SetInt("hs", hs);
        }
        score.text = "Score: " + cur;
        highscore.text = "HighScore: " + hs;
        if (cur > HelixGenerator.hg.numberOfPlatforms - 1) {
            Time.timeScale = 0;
            GameOver.endGame();
        }
    }
}
