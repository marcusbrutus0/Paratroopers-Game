using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paratrooper : MonoBehaviour
{   

    public float paratrooperSpeed;
    private Rigidbody2D rb;
    private bool touchGround = false;
    private float bottom;
    

    private void Start()
    {   
        Vector3 dimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,0));
        bottom = dimensions.y;
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {   
        if(!touchGround)

        {
            rb.position = rb.position + new Vector2(0,-1)*paratrooperSpeed*Time.fixedDeltaTime;
            
            if(rb.position.y<bottom)
            {
                touchGround = true;
                GameManager.Instance.trooperCount++;
                
                
                if(rb.position.x>0)
                {
                    GameManager.Instance.rightParatrooperCount++;
                                 
                }
                else
                { 
                    GameManager.Instance.leftParatrooperCount++;
                }
                
                if(GameManager.Instance.leftParatrooperCount>=4 || GameManager.Instance.rightParatrooperCount>=4)
                {  
                    
                    GameManager.Instance.GameOver();
                }
                
            }


        }
        
    }
}
