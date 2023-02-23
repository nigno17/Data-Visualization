using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControllerPhysics : MonoBehaviour
{
    // Player Rigidbody
    private Rigidbody playerRB;
    // Force gains
    public float motionGain = 3f;
    public float jumpGain = 7f;

    // Start is called before the first frame update
    void Start()
    {
        // Fetch the Rigidbody from the GameObject with this script attached
        playerRB = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate horizontal and vertical forces to be applyed
        Vector3 horizontalForce = Vector3.right * Input.GetAxis("Horizontal") * motionGain;
        Vector3 verticalForce = Vector3.forward * Input.GetAxis("Vertical") * motionGain;

        // apply horizontal and vertical forces
        playerRB.AddForce(horizontalForce, ForceMode.Force);
        playerRB.AddForce(verticalForce, ForceMode.Force);

        // Jump after pressing the spacebar
        if (Input.GetKeyDown(KeyCode.Space) && transform.position[1] <= 0.5)
        {
            // Calculate jump force to be applyed
            Vector3 JumpForce = Vector3.up * jumpGain;

            // apply jump force
            playerRB.AddForce(JumpForce, ForceMode.Impulse);
        }

    }
}
