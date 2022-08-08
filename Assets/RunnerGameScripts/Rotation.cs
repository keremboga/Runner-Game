using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float smooth;
    public PlayerManager playermanager; 
    private Vector3 targetAngles;
    public bool isRotated = false; 
    
    void Start()
    {
        smooth = 20f;
        isRotated = false;
        
    }

   
    void Update()
    {
		if (playermanager.gameOver)
		{
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 180, 0), Time.deltaTime * smooth); 
            

		}
        
    }
}
