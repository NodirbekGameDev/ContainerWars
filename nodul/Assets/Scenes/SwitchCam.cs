using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    public GameObject[] cameras;
    [SerializeField] private int ind = 0;

    void Update()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].SetActive(false); 
        }
        cameras[ind].SetActive(true);
    }

    public void ArrowBack(){
        if(ind != 0)ind--;
    }
    public void Next(){
        if(ind != cameras.Length- 1)ind++;
    }
    
}
