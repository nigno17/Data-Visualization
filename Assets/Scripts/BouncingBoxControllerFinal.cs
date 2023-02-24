using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBoxControllerFinal : MonoBehaviour
{
    // Game Logic component
    private GameLogicScript gameLogic;

    // Start is called before the first frame update
    void Start()
    {
        // Retrive Game Logic component
        gameLogic = GameObject.Find("GameLogic").GetComponent<GameLogicScript>();  
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy the box in cases it falls
        if (transform.position[1] < -1)
        {
            // Increase the score by 2
            gameLogic.score += 2;
            Destroy(gameObject);
        }   
    }
}
