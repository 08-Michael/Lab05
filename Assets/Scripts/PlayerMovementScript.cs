using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementScript : MonoBehaviour
{
    public GameObject CoinCountUI;

    int CoinCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            CoinCount += 10;

            CoinCountUI.GetComponent<Text>().text = "CoinCollected: " + CoinCount;

            Destroy(collision.gameObject);
        }       
    }
}
