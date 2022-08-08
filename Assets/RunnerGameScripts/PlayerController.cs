using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PlayerController : MonoBehaviour
{
   
    public SwipeManager swipe; 
    public Transform player;
    public PlayerManager playerManager;
     

    public Vector3 zMove; 
    public Vector3 desiredPosition; 
    public float swipeSensivity;
    private Vector3 swipeVector = new Vector3(0,0,0);
    public float swipeSpeed = 5.0f;
    public float forwardSpeed;
    public Vector3 desiredHorizontal; 
   
    
    public Animator animator; 
    
    void Start()
	{  
		forwardSpeed = 2.0f;
        swipeSensivity = 2.0f;
        swipeSpeed = 2.0f;
        zMove = new Vector3 (0, 0, 1); 
    }

    public void StartRunning()
	{
        PlayRunAnimation();
    }

    void Update()
    {
		if (!playerManager.isGameStarted || playerManager.gameOver)
		{
            return; 
		}
       

        zMove += Vector3.forward*forwardSpeed;
        
        



        if (swipe.swipeLeft)
        {
            print("left swipe");

            print(swipe.swipeDelta); 
            swipeVector.x -=swipeSensivity;
            
            print(" Swipe Vector =   " + swipeVector);
         
          


        }
        else if (swipe.swipeRight)
        {
            print("right swipe");
            print(swipe.swipeDelta);
            swipeVector.x+=swipeSensivity;
           
            print(" Swipe Vector =   " + swipeVector);


		}

		//desiredPosition = swipeVector + zMove;


 //       desiredHorizontal = Vector3.MoveTowards(player.transform.position, desiredPosition, swipeSpeed * Time.fixedDeltaTime);



   //     player.transform.position = new Vector3(desiredPosition.x, player.transform.position.y, desiredHorizontal.z);

        //  print("Desired Position" + desiredPosition);
        CheckGameOver(player.transform.position.z);

    }
    
	public void PlayRunAnimation()
	{
		if (playerManager.isGameStarted)
		{
            animator.SetBool("isGameStarted", true);
        }
	}

    public void PlayDanceAnimation()
    {
        if (playerManager.gameOver)
        {
            animator.SetBool("isGameStarted", false);
            animator.SetBool("isGameEnded", true);
        }
    }

    public void CheckGameOver(float distance)
	{
        if (distance >=  100)
		{
            playerManager.gameOver = true;
            PlayDanceAnimation();
        }
	}
    
}
