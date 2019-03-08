using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform Spawnpoint;
    public Rigidbody Prefab;
    public float time = 3f;

    void Start(){
        InvokeRepeating("SpawnAsteroid",time, time);
    }

    void SpawnAsteroid(){
        Rigidbody RigidPrefab;
        RigidPrefab = Instantiate(Prefab,Spawnpoint.position,Spawnpoint.rotation)as Rigidbody;
    }
}
