using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public SwipeManager swipe; 
    public Transform player;
    public playermanager playermanager;
    private Vector3 desiredPosition; 
    
   
    public float forwardSpeed; 
    

    
    
    public Animator animator; 
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        forwardSpeed = 5.0f;
        
        
       
        
    }

    
    void Update()
    {
		if (!playermanager.isGameStarted || playermanager.gameOver)
		{
            return; 
		}
        
        animator.SetBool("isGameStarted", true);
		
           desiredPosition.z = forwardSpeed;
       


        isGameOver(player.transform.position.z);

        if (swipe.swipeLeft)
        {
            
            desiredPosition += Vector3.left;
           
            
        }
        if (swipe.swipeRight)
        {
            desiredPosition += Vector3.right;
           

        }

        //player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 150f * Time.deltaTime);   


       
         
    }
    public void isGameOver(float distance)
	{
        if (distance >=  100)
		{
            animator.SetBool("isGameEnded", true);
            playermanager.gameOver = true;
           
			
             
		}
	}
    
	private void FixedUpdate()
	{
        if (!playermanager.isGameStarted || playermanager.gameOver)
        {
            return;
        }
       
        if (player.transform.position.x >=-5.5 && player.transform.position.x <= 5.5)
		{
            controller.Move(desiredPosition * Time.fixedDeltaTime);
        }
       
        

    }
}
