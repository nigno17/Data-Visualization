using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBoxController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy the box in cases it falls
        if (transform.position[1] < 0)
        {
            Destroy(gameObject, 1);
        }   
    }
}
