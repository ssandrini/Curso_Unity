using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float botBound = -30f;

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > topBound || this.transform.position.z < botBound)
        {
            Destroy(this.gameObject);
        }
    }
}
