using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public Text scoreText;
    public Text gameoverText;
    public Text gameReStartText;
    private int score;
    public bool gameover;
    public bool gameReStart;
	// Use this for initialization
	void Start ()
    {
        score = 0;

        gameoverText.text = "";
        gameover = false;

        gameReStartText.text = "";
        gameReStart = false;
    }
	
	// Update is called once per frame
	void Update () {
	    if(gameReStart)
            if (Input.GetKeyDown(KeyCode.R))
                Application.LoadLevel(Application.loadedLevel);
	}

    public void UpdateScore(int newScore)
    {
        score += newScore;
        scoreText.text = "得分：" + score;
    }

    public void GameOver()
    {
        gameover = true;
        gameoverText.text = "游戏结束";
    }

    public void GameReStart()
    {
        gameReStart = true;
        gameReStartText.text = "按 R 重新开始";
    }
}
