using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform destination;
    //public int points = 0;
    
void FixedUpdate() {
    if(Input.GetKey(KeyCode.Z)) {
        this.transform.position = new Vector3(-12.54343f,1.7f,1.124189f);//destination.position;
    }
    else if(Input.GetKey(KeyCode.X)) {
        this.transform.position = new Vector3(-6.95f,1.7f,1.3f);//destination.position;
    } 
    else if(Input.GetKey(KeyCode.C)) {
        this.transform.position = new Vector3(-.87f,1.7f,.96f);//destination.position;
    }   
}

    
}
