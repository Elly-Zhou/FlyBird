using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
  public int score;
  public Text scoreText;
  public GameObject gameOverScreen;
  public bool gameIsOver = false;
  public AudioSource dingAudio;
  public AudioSource loseAudio;
  private int highestScore;
  public Text highestScoreText;

  // Start is called before the first frame update
  void Start()
  {
    highestScore = PlayerPrefs.GetInt("HighestScore");
    setHighestScore();
  }


  [ContextMenu("Increase Score")]
  public void addScore(int scoreToAdd)
  {
    if (!gameIsOver)
    {
      score = score + scoreToAdd;
      scoreText.text = score.ToString();
      dingAudio.Play();
    }
  }

  public void restartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

  }

  public void gameOver()
  {
    if (score > highestScore)
    {
      highestScore = score;
      PlayerPrefs.SetInt("HighestScore", highestScore);
      PlayerPrefs.Save();
      setHighestScore();
    }

    gameOverScreen.SetActive(true);
    gameIsOver = true;
    loseAudio.PlayDelayed(1);
  }

  private void setHighestScore()
  {
    highestScoreText.text = highestScore.ToString();
  }
}
