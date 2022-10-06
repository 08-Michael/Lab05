using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovementScript : MonoBehaviour
{
    public GameObject CoinScore;    
    public Text TimerText;

    public float scorevalue;
    public float totalcoins;
    public float timeleft;

    private float TimerValue = 50;

    public int timeRemaining;

    int CoinCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;

        timeRemaining = Mathf.FloorToInt(timeleft % 60);

        TimerText.text = "Timer: " + timeRemaining.ToString();

        if(scorevalue == totalcoins)
        {
            if(timeleft <= TimerValue)
            {
                SceneManager.LoadScene("GameWin");
            }
        }

        else if(timeleft <= 0)
        {
            SceneManager.LoadScene("GameLose");
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            CoinCount += 10;

            CoinScore.GetComponent<Text>().text = "Score: " + CoinCount;

            Destroy(collision.gameObject);           
        }       
    }
}
