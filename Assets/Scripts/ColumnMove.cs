using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMove : MonoBehaviour
{
    float speed = 3;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        speed += 0.00001f;
    }
}
