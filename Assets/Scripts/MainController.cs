using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using Orthoverse;

public class MainController : MonoBehaviour
{
    public GameObject[] maps;
    public string[] locationNames;

    public Transform ARMapTransform;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(StaticDatas.Location);
        Debug.Log(StaticDatas.Channel);

        Shader.EnableKeyword("_DIRECTIONAL_LIGHT");
        Shader.EnableKeyword("_HOVER_LIGHT");
        Shader.EnableKeyword("_SPECULAR_HIGHLIGHTS");

        if(StaticDatas.Location == null) StaticDatas.Location = "TESTLOCATION";
        if(StaticDatas.Channel == null) StaticDatas.Channel = "TESTCHANNEL";

        StaticDatas.dm = GetComponent<DocumentManager>();

        // Map Load
        for(int i=0; i < locationNames.Length; i++){
            if(StaticDatas.Location.Equals(locationNames[i])){
                var map = (GameObject)Instantiate(maps[i], Vector3.zero, Quaternion.identity, ARMapTransform);
            }
        }

        // Avoid name ObjectRoot in Scene. It must only one in the scene. in the map.
        StaticDatas.objectRoot = GameObject.Find("ObjectRoot");

        // Load All Objects in Location&Channel
        GetComponent<APIController>().listsObject(StaticDatas.Location, StaticDatas.Channel);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
