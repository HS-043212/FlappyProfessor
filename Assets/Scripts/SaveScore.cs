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
        //Debug.Log("���ھ� ǥ��");
        printTopScorePoint.text = topScorePoint.ToString("0");
        //Debug.Log("ž ���ھ� ���");
        printTopScorePoint.color = new Color(0, 0, 0, 0);
        //Debug.Log("ž ���ھ� ǥ��");
    }

    void Update()
    {
        printScorePoint.text = scorePoint.ToString("0");
        //Debug.Log("���ھ� ���");

        if (scorePoint > topScorePoint)
        {
            topScorePoint = scorePoint;

            PlayerPrefs.SetInt("TopScore", topScorePoint);
            //Debug.Log("ž ���ھ� ����");
        }

        printTopScorePoint.text = topScorePoint.ToString("0");
        //Debug.Log("ž ���ھ� ���");
    }
}
