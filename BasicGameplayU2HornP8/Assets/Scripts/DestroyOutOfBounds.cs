using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 30;
    // Update is called once per frame
    void Update()
    {
        // if an object goes pAST the players view in the game remove the object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            Debug.Log("Game Over!"); Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            Debug.Log("Game Over!"); Destroy(gameObject);
        }
    }
}




