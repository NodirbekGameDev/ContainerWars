using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerManager : MonoBehaviour
{

    public Transform[] locates;
    public GameObject[] objs;
    // Start is called before the first frame update
    void Start()
    {
        for(int a = 0; a < Random.Range(5, 10); a++ ){
            int _random = Random.Range(0, locates.Length);
            if(!GameObject.Find(_random.ToString()))
                Instantiate(objs[Random.Range(0, objs.Length)], locates[_random].position, Quaternion.identity).name = _random.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
