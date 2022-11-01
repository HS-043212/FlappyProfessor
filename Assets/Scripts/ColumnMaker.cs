using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMaker : MonoBehaviour
{
    public GameObject Column;
    public float timeset;
    float timer = 0;

    void Start()
    {
        
    }
    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeset)
        {
            GameObject newcolumn = Instantiate(Column);
            newcolumn.transform.position = new Vector3(6, Random.Range(-6f, 0f), 0);
            timer = 0;
            Destroy(newcolumn, 5);
        }        
    }
}
