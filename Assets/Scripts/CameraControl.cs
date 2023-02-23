using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Reference to the player GameObject
    private GameObject playerGO;
    // Initial distance between camera and player
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // Find the player GameObject
        playerGO = GameObject.Find("Player");
        // Calculate the offset
        offset = transform.position - playerGO.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Update the camera position to follow the player
        transform.position = playerGO.transform.position + offset;
    }
}
