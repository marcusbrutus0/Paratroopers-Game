using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParatrooperSpawner : MonoBehaviour
{
    
    public float minTime;
    public float maxTime;
    public float nextSpawnTime;
    public GameObject paratrooperPrefab;


    void Start()
    {
        nextSpawnTime = Random.Range(minTime,maxTime);
    }

    
    void Update()
    {  
        if(GameManager.Instance.gameOver)
        { 
            return;
        }

        
        
        if(nextSpawnTime<0)
        {
            var paratrooper = Instantiate(paratrooperPrefab);
            paratrooper.transform.position = transform.position;
            nextSpawnTime = Random.Range(minTime,maxTime);
        }
        nextSpawnTime = nextSpawnTime - Time.deltaTime;


        
    }
}
