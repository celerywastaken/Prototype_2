using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAnimals : MonoBehaviour
{
    private float topBound = 40;
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OutofBoundDestroy();

    }

    private void OutofBoundDestroy()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
