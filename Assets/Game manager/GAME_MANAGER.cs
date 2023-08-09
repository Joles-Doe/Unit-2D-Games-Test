using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class PlayerStats
{
    public static bool start = false;
}

public class GAME_MANAGER : MonoBehaviour
{
    public GameObject Menuscreen;
    public GameObject Gameoverscreen;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerStats.start == false)
        {
            Debug.Log("start");
            PlayerStats.start = true;
            Menuscreen.SetActive(true);
            Gameoverscreen.SetActive(false);
            Time.timeScale = 0;
        }
        else
        {
            Debug.Log("Start true");
            Menuscreen.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void GameOver()
    {
        Gameoverscreen.SetActive(true);
        Menuscreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void Retry()
    {
        SceneManager.LoadScene(0);
    }
}
