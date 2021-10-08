using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public Transform objectToRotate;
    private float speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(objectToRotate.position, Vector3.forward, 10 * Time.deltaTime * speed);
    }
}




