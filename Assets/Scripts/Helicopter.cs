using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    private float currentSpeed;
    public float initialX;
    public Rigidbody2D rb;

    void Start()
    {
        currentSpeed = Random.Range(minSpeed,maxSpeed);
        if(transform.position.x>0)
        {
            currentSpeed = currentSpeed*-1;
        }
        initialX = transform.position.x;
        rb=GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {  
        
        rb.position = rb.position + new Vector2(1,0)*currentSpeed*Time.fixedDeltaTime;
         if(Mathf.Abs(rb.position.x)>Mathf.Abs(initialX))
         { 
            Destroy(gameObject);   
       }
    }
     void OnTriggerEnter2D(Collider2D col)
     {
        if(col.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            
        } 
        Debug.Log("bullet colliding"+ col.tag);
     }

}
