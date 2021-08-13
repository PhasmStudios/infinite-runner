using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    //variables
    public float moveSpeed = 2f;

    private void Start()
    {
        Destroy(gameObject, 15f);
    }
    private void Update()
    {
        Move();
    }

    //Moves on z axis
    private void Move()
    {
        transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
    }
}
