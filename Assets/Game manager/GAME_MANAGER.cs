using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAME_MANAGER : MonoBehaviour
{
    public GameObject Menuscreen;

    // Start is called before the first frame update
    void Start()
    {
        Menuscreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Menuscreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void Retry()
    {
        SceneManager.LoadScene(0);
    }
}
