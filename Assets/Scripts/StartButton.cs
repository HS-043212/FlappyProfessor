using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Play");
        Time.timeScale = 1;
        SaveScore.scorePoint = 0;
    }
}