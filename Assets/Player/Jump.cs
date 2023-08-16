using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Jump : MonoBehaviour
{
    public float vel = 1;
    public float angle = 0;
    public float angle_speed = 5;
    private bool stop_rotate = false;
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


        if (stop_rotate == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * angle_speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
        stop_rotate = true;
    }
}
