using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {    
    }

    // Event triggered when a collision occours
    void OnCollisionEnter(Collision collision)
    {
        // The gameObject destroys itself
        Destroy(gameObject);
    }
}
