using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResLoaderScript : MonoBehaviour
{
    private Object[] textures;
    private Object[] materials;
    private GameObject myCube;
    private GameObject myBackground;
    private MeshRenderer cubeMaterial;
    RawImage BGRawImage;

    public float frequency;

    // Start is called before the first frame update
    void Start()
    {
        textures = Resources.LoadAll("Textures", typeof(Texture2D));
        materials = Resources.LoadAll("Materials", typeof(Material));

        myCube = GameObject.Find("Cube");
        myBackground = GameObject.Find("BGImage");

        cubeMaterial = myCube.GetComponent<MeshRenderer>();
        BGRawImage = myBackground.GetComponent<RawImage>();

        StartCoroutine(changeApperance(frequency));
    }

    // Update is called once per frame
    void Update()
    {   
    }

    private IEnumerator changeApperance(float waitTime)
    {
        while(true)
        {
            Texture2D newTexture = (Texture2D)textures[Random.Range(0, textures.Length)];
            Material newMaterial = (Material)materials[Random.Range(0, materials.Length)];

            cubeMaterial.material = newMaterial;
            BGRawImage.texture = newTexture;

            // interupt the execution here for "waitTime" seconds (next iteration it will start from here as well)
            yield return new WaitForSeconds(waitTime);
        }
    }
}
