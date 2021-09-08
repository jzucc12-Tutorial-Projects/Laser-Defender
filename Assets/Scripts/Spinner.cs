using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float rotationRate = 20;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotationRate * Time.deltaTime));
    }
}
