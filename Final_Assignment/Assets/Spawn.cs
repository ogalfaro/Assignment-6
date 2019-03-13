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
        time = Random.value;
        Rigidbody RigidPrefab;
        //RigidPrefab = Instantiate(Prefab,Spawnpoint.position,Spawnpoint.rotation)as Rigidbody;
        RigidPrefab = Instantiate(Prefab, new Vector3(Random.Range(-11f,3f),Random.Range(10f,13f),1f), Quaternion.identity)as Rigidbody;

    }
}
