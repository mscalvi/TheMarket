using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialization : MonoBehaviour
{
    public GameObject StatusBar;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(StatusBar, Vector3.zero, Quaternion.identity);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
