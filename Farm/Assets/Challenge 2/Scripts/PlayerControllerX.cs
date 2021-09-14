using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float rechargeTime = 1f;

    private float counter = 0;
    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        // On spacebar press, send dog
        if (counter > rechargeTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                counter = 0;
            }
        }
    }
}
