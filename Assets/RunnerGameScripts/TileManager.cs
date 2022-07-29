using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject tile;
  
    public float spawn;
    public float tileLength;
    
    
   
    void Start()
    {
        spawn = 0.0f;
        tileLength = 10f; 
        for(int i = 0; i <10; i++)
		{
             
            SpawnTile();
		}
    }

    
    void Update()
    {
       
    }
    public void SpawnTile()
	{
        Instantiate(tile, transform.forward * spawn, transform.rotation);
        spawn += tileLength;
	
    }
}
