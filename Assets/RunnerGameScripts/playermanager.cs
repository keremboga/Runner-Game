using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playermanager : MonoBehaviour
{
    public Text gameOverText;
    public bool gameOver;
    public GameObject startingText;
    public SwipeManager swipe;
    public PlayerController playercontroller; 
    

    public bool isGameStarted;
    
    
    void Start()
    {
        
        gameOver = false;
        isGameStarted = false; 
    }

    
    void Update()
    {
		if (gameOver)
		{
            Time.timeScale = 1.0f;
            
           
           
            
		}
		if (swipe.tap)
		{
            isGameStarted = true;
            Destroy(startingText); 
		}
    }
}
