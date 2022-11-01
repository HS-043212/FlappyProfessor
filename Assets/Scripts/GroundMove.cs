using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    float _distance = 6.14f;
    int _count = 2;
    int _index = 2;
    float plusTime = 0;

    public GameObject[] grounds;

    private void Update()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;

        if (Time.timeScale == 0)
        {
            return ;
        }

        gameObject.transform.localPosition += new Vector3(-0.05f - plusTime, 0, 0);
        plusTime += 0.000001f;

        _count = 2 + (int)(-gameObject.transform.localPosition.x / 6.14f);

        if(_index != _count)
        {
            grounds[(_index - 2) % 3].transform.localPosition = new Vector3(_distance * _count, -4.1f, 0);
            _index = _count;
        }
    }
}