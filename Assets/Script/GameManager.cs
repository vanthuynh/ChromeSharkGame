using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GOPanel;

    AudioSource loseSound;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        loseSound = GetComponent<AudioSource>();
    }

    public void GameOver()
    {
        loseSound.Play();

        // if we put 2 here, the game will double speed
        Time.timeScale = 0;
        GOPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
