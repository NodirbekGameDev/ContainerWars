using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dream : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] locates;
    public GameObject[] gameObjects;


    void Start()
    {
        for(int i = 0 ; i < Random.Range(5, 10); i++)
            Instantiate(gameObjects[Random.Range(0, gameObjects.Length)],locates[Random.Range(0, locates.Length)].position, Quaternion.identity);  
        

    }
// Random.Range(locates.Length)
    // Update is called once per frame
    void Update()
    {
        
    }
}
