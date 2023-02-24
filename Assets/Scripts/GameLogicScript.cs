using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// import TMPro to use textMesh pro components
using TMPro;
// remember to import the UnityEngine.SceneManagement to load a scene
using UnityEngine.SceneManagement;

public class GameLogicScript : MonoBehaviour
{
    // Score of the game
    public int score {get; set;}
    // Start time of the game
    private float startTime;
    // Text shown in the HUD
    private TextMeshProUGUI textDisplay;
    // Reference to Boxes Prefabs
    public GameObject BBox;
    public GameObject Box;
    // Game duration in seconds
    public float gameDuration;
    //Spawning boxes frequency
    public float spawningFreq;

    // Start is called before the first frame update
    void Start()
    {   
        // Initialize score and initial time
        score = 0;
        startTime = Time.time;

        // Reference to the HUD score text GameObject
        textDisplay = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        
        // Start the coroutine that spawns the boxes
        StartCoroutine(spawnBoxes(spawningFreq));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Runs right after the Update
    private void LateUpdate() 
    {
        // Update the HUD score text
        textDisplay.text = "Score: " + score;    
    }

    // Coroutine to spawn the boxes
    private IEnumerator spawnBoxes(float waitTime)
    {
        while(true)
        {
            // If the playing time finishes comes back to the main menu scene
            if (Time.time - startTime > gameDuration)
            {
                SceneManager.LoadScene("FinalMain", LoadSceneMode.Single);
            }

            // Spawn a new bouncing box and a new box from their prefabs
            Instantiate(BBox, new Vector3(Random.Range(-4.5f, 4.5f), 5f, Random.Range(-4.5f, 3.5f)), Quaternion.identity);
            Instantiate(Box, new Vector3(Random.Range(-4.5f, 4.5f), 0.5f, Random.Range(-4.5f, 3.5f)), Quaternion.identity);

            // interupt the execution here for "waitTime" seconds (next iteration it will start from here as well)
            yield return new WaitForSeconds(waitTime);
        }
    }
}
