using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   

   private Rigidbody2D rb;
   public float bulletSpeed;
   public float bulletMaxDistance;
   private Vector2 initialPosition;

   private void Start()
   {  
     rb=GetComponent<Rigidbody2D>();
     initialPosition = transform.position;

   }
    
   private void FixedUpdate() 
   {   
       var updatedPosition=transform.up*bulletSpeed*Time.fixedDeltaTime;
       rb.position = rb.position + new Vector2(updatedPosition.x,updatedPosition.y);
       var distance = initialPosition - rb.position;
       if(distance.magnitude>bulletMaxDistance)
       {
        Destroy(gameObject); //all mono behaviour classes have a gameobject property 
       }
    

   } 


   


} 
