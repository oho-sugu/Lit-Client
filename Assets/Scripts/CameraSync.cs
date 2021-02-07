using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSync : MonoBehaviour
{
    public GameObject arcamera;
    // Update is called once per frame
    void Update()
    {
        Quaternion q = arcamera.transform.rotation;
        Quaternion q2 = Quaternion.Euler(50, q.eulerAngles.y, 0f);
        gameObject.transform.rotation = q2;
    }
}
