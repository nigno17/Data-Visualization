using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// remember to import the UnityEngine.SceneManagement to load a scene
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // On button start pressed it loads the main game scene
    public void StartPressed()
    {
        // Load the scene named "FinalRunning" (Final example scene)
        SceneManager.LoadScene("FinalRunning", LoadSceneMode.Single);
    }
}
