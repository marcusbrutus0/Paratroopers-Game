using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public bool gameOver = false;
   private static GameManager instance;
   public static GameManager Instance
   { 
    get 
    { 
        if(instance is null)
        
            Debug.Log("game manager is NULL");
            return instance;
        
    }
   }
   private void Awake()
   { 
    instance = this;
   }

public int trooperCount = 0; 
public int leftParatrooperCount = 0;
public int rightParatrooperCount = 0;


public void GameOver() 
{ 
    gameOver=true;
}

   

}
