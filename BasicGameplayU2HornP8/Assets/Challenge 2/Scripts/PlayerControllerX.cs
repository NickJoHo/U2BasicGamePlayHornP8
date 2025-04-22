using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private Boolean canSpawnDog = true;
    void Start()
    {
        InvokeRepeating("ResetTimer", 1.0f, 1.0f);
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawnDog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSpawnDog = false;
        }
    }
    void ResetTimer()
    {
        canSpawnDog = true;
    }
}
