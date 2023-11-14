using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleScreenLogic : MonoBehaviour
{
    public void play() {
      SceneManager.LoadScene("GameScreen");
    }
}
