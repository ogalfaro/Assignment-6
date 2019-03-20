using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHeart3 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(DestroyScript.Life == 2f){
            Destroy(this.gameObject);
        }
    }
}
