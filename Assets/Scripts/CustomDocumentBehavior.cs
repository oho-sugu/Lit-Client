using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Orthoverse;
using Orthoverse.DOM;
using Orthoverse.DOM.Entity;

public class CustomDocumentBehavior : MonoBehaviour
{
    public DocumentManager dm;

    void Awake(){
        dm.setPostInitDocumentDelegate(PostInitDocument);
        dm.setPostRenewDocumentDelegate(PostRenewDocument);
        dm.setPostLinkAction(PostLinkAction);
    }

    public void PostInitDocument(Container con, object param){
        var od = (APIController.ObjectData)param;
        var oc = con.gameObject.AddComponent<ObjectController>();
        oc.objectData = od;
        con.gameObject.transform.localPosition = od.position;
        con.gameObject.transform.localScale = od.scale;
        con.gameObject.transform.localRotation = od.rotation;
        var parentTransform = StaticDatas.objectRoot.transform.Find(od.channel);
        con.gameObject.transform.SetParent(parentTransform, false);
        con.gameObject.transform.hasChanged = false;
    }

    public void PostRenewDocument(Container con){
    }

    public void PostLinkAction(EntityBase e){
    }
}
