using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addscore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score_tracker.score++;
    }
}
