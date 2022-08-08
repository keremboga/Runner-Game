using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
    
{
    public PlayerManager playermanager;
    public Transform playerParent; 
    private CharacterController controller;
    private Vector3 direction = new Vector3(0, 0, 6);
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (!playermanager.isGameStarted || playermanager.gameOver)
        {
            return;
        }
		if (!playermanager.gameOver)
		{
            playerParent.transform.position += direction*Time.deltaTime; 
          //  controller.Move(direction * Time.deltaTime);
        }
       
    }
}
