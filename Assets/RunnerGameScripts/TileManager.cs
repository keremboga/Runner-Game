using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject tile;
  
    public float spawnCounter;
    public float tileLength;
    
    
   
    void Start()
    {
        spawnCounter = 0.0f;
        tileLength = 10f; 
        for(int i = 0; i <50; i++)
		{
             
            SpawnTile();
		}
    }

    
    
    public void SpawnTile()
	{
        Instantiate(tile, transform.forward * spawnCounter, transform.rotation);
        spawnCounter += tileLength;
	
    }
}
