using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHeart1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(DestroyScript.Life == 0f){
            Destroy(this.gameObject);
        }
        
    }
}
