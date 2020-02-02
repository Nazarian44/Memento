using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationtest : MonoBehaviour
{    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Transform>().Rotate(0f, 0f, 5f, Space.Self);
        //Quaternion theRotation = transform.localRotation;
        //theRotation.z = 5;
        GetComponent<Transform>().Rotate(Vector3.forward);
    }
}
