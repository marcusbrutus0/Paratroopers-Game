using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterSpawner : MonoBehaviour
{

    public float minSeconds;
    public float maxSeconds;
    private float nextSpawnTime;
    public GameObject helicopterPrefab;
    public Transform leftPos;
    public Transform rightPos;

    private void Start()
    {
    nextSpawnTime=Random.Range(minSeconds,maxSeconds);
    }

    private void Update()
    { 

        if(GameManager.Instance.gameOver)
        { 
            return;
        }

        
        if(nextSpawnTime<0)
        {   

            var helicopter = Instantiate(helicopterPrefab);
            var coinToss = Random.Range(0,10);
            if(coinToss>5)
            {
               helicopter.transform.position = leftPos.position;
            }
            else 
            {
               helicopter.transform.position = rightPos.position;
            }
            nextSpawnTime = Random.Range(minSeconds,maxSeconds);
            
            
        }
        nextSpawnTime = nextSpawnTime - Time.deltaTime;

         
    }




}
