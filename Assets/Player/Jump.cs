using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float vel = 1;
    private Rigidbody2D rb;
    public GAME_MANAGER gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // accesses the Rigidbody2D component
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // jump
            rb.velocity = Vector2.up * vel;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
