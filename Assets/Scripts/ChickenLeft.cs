using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenLeft : MonoBehaviour
{
    public float speed = 10.0f;
    private float topBound = 30;
    private float lowerBound = -30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.x > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
