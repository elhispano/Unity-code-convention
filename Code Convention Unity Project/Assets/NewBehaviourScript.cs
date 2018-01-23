using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public bool count = false;

    int counter = 0;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update ()
    {

        if (count) { counter++; }
    }
}
