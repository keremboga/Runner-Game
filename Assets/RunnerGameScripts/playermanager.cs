using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerManager : MonoBehaviour
{
    public Text gameOverText;
    public bool gameOver;
    public GameObject startingText;
    public SwipeManager swipe;
    public PlayerController playercontroller;
    public GameObject endingCamera; 
    

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

            endingCamera.SetActive(true); 
            
            
           
            
		}
		if (swipe.tap && !isGameStarted)
		{
            isGameStarted = true;
            startingText.SetActive(false);

            playercontroller.StartRunning();
		}
    }
}
