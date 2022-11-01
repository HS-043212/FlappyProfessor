using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float jumpPower;

    private Touch tempTouchs;

    public bool isStart = false;
    public bool isDie = false;

    public Image ScoreBoard;

    public AudioSource audioSource;
    public AudioClip touch;    
    public AudioClip dead;

    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDie)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, jumpPower);
            isStart = true;

            audioSource.PlayOneShot(touch, 0.3f);
        }
        if (Input.touchCount > 0 && !isDie)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                tempTouchs = Input.GetTouch(i);
                if (tempTouchs.phase == TouchPhase.Began)
                {
                    rigid.velocity = new Vector2(rigid.velocity.x, jumpPower);
                    isStart = true;

                    audioSource.PlayOneShot(touch, 0.3f);
                }
            }
        }

        if (!isStart) return;

        if (transform.position.y > 4.8f)
            rigid.position = new Vector2(0f, 4.8f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(dead, 0.3f);
        Time.timeScale = 0;
        GameOver();
    }

    public void GameOver()
    {
        isDie = true;
        ScoreBoard.color = new Color(1, 1, 1, 1);
        SaveScore.printScorePoint.transform.localPosition = new Vector3(-105, 29, 0);
        SaveScore.printScorePoint.color = new Color(0.3294118f, 0.172549f, 0, 1);
        //Debug.Log("스코어 텍스트 색 변경");
        SaveScore.printTopScorePoint.color = new Color(0.3294118f, 0.172549f, 0, 1);        
        //Debug.Log("탑 스코어 텍스트 색 변경");
    }
}