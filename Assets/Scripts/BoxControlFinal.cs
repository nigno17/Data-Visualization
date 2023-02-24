using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControlFinal : MonoBehaviour
{
    // Game Logic component
    private GameLogicScript gameLogic;

    // Start is called before the first frame update
    void Start()
    {    
        // Retrive Game Logic component
        gameLogic = GameObject.Find("GameLogic").GetComponent<GameLogicScript>(); 
    }

    // Event triggered when a collision occours
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            // Increase the score by 1
            gameLogic.score += 1;
            // The gameObject destroys itself
            Destroy(gameObject);
        }
    }
}
