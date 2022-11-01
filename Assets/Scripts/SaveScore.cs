using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveScore : MonoBehaviour
{
    public static int scorePoint;
    public static int topScorePoint;

    public static Text printScorePoint;
    public static Text printTopScorePoint;

    void Start()
    {
        printScorePoint = GameObject.Find("Score").GetComponent<Text>();
        printTopScorePoint = GameObject.Find("TopScore").GetComponent<Text>();

        topScorePoint = PlayerPrefs.GetInt("TopScore", 0);

        printScorePoint.color = new Color(0, 0, 0, 1);
        //Debug.Log("스코어 표시");
        printTopScorePoint.text = topScorePoint.ToString("0");
        //Debug.Log("탑 스코어 출력");
        printTopScorePoint.color = new Color(0, 0, 0, 0);
        //Debug.Log("탑 스코어 표시");
    }

    void Update()
    {
        printScorePoint.text = scorePoint.ToString("0");
        //Debug.Log("스코어 출력");

        if (scorePoint > topScorePoint)
        {
            topScorePoint = scorePoint;

            PlayerPrefs.SetInt("TopScore", topScorePoint);
            //Debug.Log("탑 스코어 저장");
        }

        printTopScorePoint.text = topScorePoint.ToString("0");
        //Debug.Log("탑 스코어 출력");
    }
}
