using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControls : MonoBehaviour
{
   
   public float rotateSpeed = 10f; 
   private float currentRotation = 0f;
   
   private void Start()
   { 
      Vector3 dimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,0));
      transform.position = new Vector3(0,dimensions.y,0);
   }
   private void Update() 
   {
      if(GameManager.Instance.gameOver)
      {
         return;
      }
      float h = Input.GetAxis("Horizontal");
      
      if(h<0) 
      {  
         currentRotation = currentRotation+rotateSpeed*Time.deltaTime;
         
      }
      else if(h>0) { 
         
         currentRotation = currentRotation-rotateSpeed*Time.deltaTime;
         
        
         //Debug.Log(currentRotation);
      }

      if(currentRotation>90)
      {
       currentRotation=90;
      } 
      if(currentRotation<-90)
      {
         currentRotation=-90;
      }

      transform.rotation = Quaternion.Euler(0,0,currentRotation);
   }

   }


