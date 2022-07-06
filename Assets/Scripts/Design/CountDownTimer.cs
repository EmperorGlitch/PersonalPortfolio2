using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject loseCanvas;

    private float currentTime;
    private int countDownSecond = 1;
    [SerializeField] float startingTime;
    [SerializeField] TextMeshProUGUI countDownText;

    private void Start()
    {
        currentTime = startingTime;

    }

    public void StartTheTimer()
    {
        currentTime = startingTime;
    }
    public void GameOver()
    {
    }
  
    void Update()
    {
        currentTime -= countDownSecond * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");
        // turn text red when the timer is below 10 seconds
        if (currentTime < 10)
        {
            countDownText.color = Color.red;
        }

        // Do Something when timer is at 0
        if (currentTime < 0)
        {
            countDownSecond = 0;
            GameOver();
            loseCanvas.SetActive(true);
        }
    }
}
