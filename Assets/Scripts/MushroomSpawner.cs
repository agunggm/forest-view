using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    public GameObject objPrefab;
    
    void FixedUpdate(){
        Instantiate(objPrefab, transform.position, Quaternion.identity);
    }
}
