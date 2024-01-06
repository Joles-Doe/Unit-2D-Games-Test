using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class PlayerStats
{
    public static bool start = false;
    public static int colour_counter = 0;
    public static int[] colour_RGB = { 255, 255, 255 };
}

public class GAME_MANAGER : MonoBehaviour
{
    public GameObject Menuscreen;
    public GameObject Gameoverscreen;
    public GameObject Scorescreen;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerStats.start == false)
        {
            Debug.Log("start");
            PlayerStats.start = true;
            Menuscreen.SetActive(true);
            Gameoverscreen.SetActive(false);
            Scorescreen.SetActive(false);
            Time.timeScale = 0;
        }
        else
        {
            Debug.Log("Start true");
            Menuscreen.SetActive(false);
            Scorescreen.SetActive(true);
            Time.timeScale = 1;
        }
    }

    private void Update()
    {
        if (PlayerStats.colour_counter >= 2)
        {
            Debug.Log("CHANGE COLOUR");
            PlayerStats.colour_counter = 0;
            PlayerStats.colour_RGB = new int[] { UnityEngine.Random.Range(0, 255), UnityEngine.Random.Range(0, 255), UnityEngine.Random.Range(0, 255) };
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
