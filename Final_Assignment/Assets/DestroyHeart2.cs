using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHeart2 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(DestroyScript.Life == 1f){
            Destroy(this.gameObject);
        }   
    }
}
