using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localRotation *= Quaternion.AngleAxis(speed , Vector3.forward);
    }
}
