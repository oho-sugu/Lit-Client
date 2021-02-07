using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChannelButtonController : MonoBehaviour
{
    void OnEnable(){
        Text text = transform.Find("Text").GetComponent<Text>();
        if(!StaticDatas.objectRoot.transform.Find(text.text).gameObject.activeSelf){
            gameObject.GetComponent<Image>().color = Color.gray;
        } else {
            gameObject.GetComponent<Image>().color = Color.white;
        }
    }

    public void push(){
        Text text = transform.Find("Text").GetComponent<Text>();
        if(StaticDatas.objectRoot.transform.Find(text.text).gameObject.activeSelf){
            StaticDatas.objectRoot.transform.Find(text.text).gameObject.SetActive(false);
            gameObject.GetComponent<Image>().color = Color.gray;
        } else {
            StaticDatas.objectRoot.transform.Find(text.text).gameObject.SetActive(true);
            gameObject.GetComponent<Image>().color = Color.white;
        }
    }
}
