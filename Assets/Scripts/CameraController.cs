using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ARCamera;
    public GameObject BVCamera;

    private bool ar = true;

    public void AROn(){
        if(ar){
            ARCamera.SetActive(false);
            BVCamera.SetActive(true);
            ar = false;
        } else {
            ARCamera.SetActive(true);
            BVCamera.SetActive(false);
            ar = true;
        }
    }
}
