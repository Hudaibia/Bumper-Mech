using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotatioSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizonatlInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up,  horizonatlInput * rotatioSpeed * Time.deltaTime);
    }
}
