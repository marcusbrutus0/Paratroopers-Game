using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControls : MonoBehaviour
{
    
    public GameObject bulletPrefab; 
    public float maxFireRate;
    private float currentFireTime=-1;
   
    private void Update()
    {      
        if(GameManager.Instance.gameOver)
        { 
            return;
        }

        
        if(Input.GetKeyDown(KeyCode.Space) && currentFireTime<0)
        { 
            var bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            currentFireTime = maxFireRate;
        } 

        currentFireTime = currentFireTime-Time.deltaTime;
        if (currentFireTime<-1)
        {
            currentFireTime=-1;
        }
        
    }
    


}
