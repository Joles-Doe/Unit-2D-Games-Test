using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public float maxtime = 1;
    private float timer = 0;
    public float despawn_time = 15;
    public GameObject obstacle;
    public float height;


    // Start is called before the first frame update
    void Start()
    {
        GameObject new_obstacle = Instantiate(obstacle);
        new_obstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(new_obstacle, despawn_time);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxtime)
        {
            timer = 0;

            GameObject new_obstacle = Instantiate(obstacle);
            new_obstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(new_obstacle, despawn_time);
        }

        timer += Time.deltaTime;
    }   
}
