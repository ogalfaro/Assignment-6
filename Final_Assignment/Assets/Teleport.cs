using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform destination;
    //public int points = 0;
    
void FixedUpdate() {
    if(Input.GetKey(KeyCode.Z)) {
        this.transform.position = new Vector3(-6.208f,1.996f,0.97f);//destination.position;
    } 
    else if(Input.GetKey(KeyCode.X)) {
        this.transform.position = new Vector3(-1.557f,1.996f,0.97f);//destination.position;
    }   
}

    
}
