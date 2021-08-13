using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    //variables
    public float spawnRate = 1f;
    private float timer;
    public GameObject obstacleBase;

    private void Start()
    {
        timer = 0f;
    }

    private void Update()
    {
        if (Time.time > timer)
        {
            Instantiate(obstacleBase, new Vector3(0, 0, 30f), Quaternion.identity);
            timer = spawnRate + Time.time;
        }
    }
}
