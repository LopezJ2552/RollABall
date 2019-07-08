using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMover : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 pointA = new Vector3(-6.29f, 0.5f, -2.79f);
    Vector3 pointB = new Vector3(6.29f, 0.5f, -2.79f);
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time * 0.5f, 1));
    }
}
