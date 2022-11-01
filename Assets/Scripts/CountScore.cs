using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SaveScore.scorePoint++;
        //Debug.Log("스코어 증가");
    }
}
