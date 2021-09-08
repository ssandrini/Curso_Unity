using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnPosZ = 30;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosZ = this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
