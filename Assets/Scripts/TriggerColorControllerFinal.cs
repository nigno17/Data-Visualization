using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColorControllerFinal : MonoBehaviour
{
    // Variable to store the player's color
    Material playerMaterial;
    // Game Logic component
    private GameLogicScript gameLogic;

    // Start is called before the first frame update
    void Start()
    {
        // Retrive player's gameObject 
        GameObject playerGO = GameObject.FindWithTag("Player");
        // Get the player's Material
        playerMaterial = playerGO.GetComponent<MeshRenderer>().material;  
        
        // Retrive Game Logic component
        gameLogic = GameObject.Find("GameLogic").GetComponent<GameLogicScript>();  
    }

    // Event triggered when the player enters in the trigger collision area
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            // Change color of the player
            playerMaterial.color = Random.ColorHSV();
            // Reset the score
            gameLogic.score = 0;
        }       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
