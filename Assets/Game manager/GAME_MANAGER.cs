using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAME_MANAGER : MonoBehaviour
{
    public GameObject Endscreen;

    // Start is called before the first frame update
    void Start()
    {
        Endscreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Endscreen.SetActive(true);
        Time.timeScale = 0;
    }
}
