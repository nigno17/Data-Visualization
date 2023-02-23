using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Speed gain
    public float movSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {    
    }

    // Update is called once per frame
    void Update()
    {
        //Update the player position. Control via arrow keys
        transform.position = transform.position + new Vector3(Input.GetAxis("Horizontal") * movSpeed * Time.deltaTime,
                                                              0,
                                                              Input.GetAxis("Vertical") * movSpeed * Time.deltaTime);
    }
}
