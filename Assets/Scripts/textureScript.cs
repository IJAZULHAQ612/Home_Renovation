using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textureScript : MonoBehaviour
{
    public GameObject floor;
    public Texture [] texture;
    private Renderer renderfloor; // object appear in screen 
    private int random;

    // Start is called before the first frame update
    void Start()
    {
        renderfloor = floor.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeTexture);
    }
    void ChangeTexture()
    {
        random = Random.Range(0, texture.Length);
        renderfloor.material.mainTexture = texture[random];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
