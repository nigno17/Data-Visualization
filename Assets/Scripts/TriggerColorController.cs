using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColorController : MonoBehaviour
{
    // Variable to store the player's color
    Material playerMaterial;
    // Start is called before the first frame update
    void Start()
    {
        // Retrie player's gameObject 
        GameObject playerGO = GameObject.FindWithTag("Player");
        // Get the player's Material
        playerMaterial = playerGO.GetComponent<MeshRenderer>().material;    
    }

    // Event triggered when the player enters in the trigger collision area
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            // Change color of the player
            playerMaterial.color = Random.ColorHSV();   
        }       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
