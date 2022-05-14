using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyM : MonoBehaviour
{
    void Awake() {
        {
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}
