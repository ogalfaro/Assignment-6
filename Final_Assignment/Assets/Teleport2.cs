using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport2 : MonoBehaviour
{
    public Transform destination;
    //public int points = 0;
    
void FixedUpdate() {
    if(Input.GetKey(KeyCode.Z)) {
        this.transform.position = new Vector3(-12.39f,4.02f,1.46f);//destination.position;
    }
    else if(Input.GetKey(KeyCode.X)) {
        this.transform.position = new Vector3(-6.76f,4.02f,1.46f);//destination.position;
    } 
    else if(Input.GetKey(KeyCode.C)) {
        this.transform.position = new Vector3(-1.356951f,4.330102f,2.820631f);//destination.position;
    }   
}

    
}
