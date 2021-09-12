using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    float maxTime;
    float timer;

    public GameObject obstacle1;

    // Start is called before the first frame update
    void Start()
    {
        maxTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= maxTime)
        {
            //Generate Obstacle
            GenerateObstacle();
            timer = 0;
        }
    }
    void GenerateObstacle()
    {
        GameObject newObstacle = Instantiate(obstacle1);
    }

}
