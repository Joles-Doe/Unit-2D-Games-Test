using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public float maxtime = 2;
    private float timer = 0;
    public float despawn_time = 15;
    public GameObject obstacle;
    public float height;


    // Start is called before the first frame update
    void Start()
    {
        obstacle.GetComponentInChildren<Renderer>().sharedMaterial.color = new Color((float)PlayerStats.colour_RGB[0] / 255, (float)PlayerStats.colour_RGB[1] / 255, (float)PlayerStats.colour_RGB[2] / 255);

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
            obstacle.GetComponentInChildren<Renderer>().sharedMaterial.color = new Color((float)PlayerStats.colour_RGB[0] / 255, (float)PlayerStats.colour_RGB[1] / 255, (float)PlayerStats.colour_RGB[2] / 255);

            GameObject new_obstacle = Instantiate(obstacle);
            new_obstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(new_obstacle, despawn_time);
        }

        timer += Time.deltaTime;
    }   
}
