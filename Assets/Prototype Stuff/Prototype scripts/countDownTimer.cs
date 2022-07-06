using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class countDownTimer : MonoBehaviour
{
    // Start is called before the first frame update

    private float currentTime;
    private int countDownSecond = 1;
    [SerializeField] float startingTime;
    [SerializeField] Text countDownText;

    private void Start()
    {
        currentTime = startingTime;
        
    }
   public void GameOver()
    {
        SceneManager.LoadScene("GameOverScreen");
    }
    void Update()
    {
        currentTime -= countDownSecond * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");

    
   
        if (currentTime < 30)
        {
            countDownText.color = Color.yellow;
        }
        if (currentTime < 10)
        {
            countDownText.color = Color.red;
        }
        if (currentTime < 0){
            countDownSecond = 0;
            GameOver();
        }
    }
}
