using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyText : MonoBehaviour
{
    public float DestroyTime = 3f;
    public Vector3 RandomizeIntensity = new Vector3(0.5f,0f,0f);
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,DestroyTime);
        transform.localPosition += new Vector3(Random.Range(-RandomizeIntensity.x,RandomizeIntensity.x),Random.Range(-RandomizeIntensity.y,RandomizeIntensity.y),Random.Range(-RandomizeIntensity.z,RandomizeIntensity.z));
    }


}
