using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadMain : MonoBehaviour
{
    public GameObject dropdownLocation;

    public void PushStart(){
        StaticDatas.Location = dropdownLocation.GetComponent<Dropdown>().captionText.text;

        SceneManager.LoadScene("Main");
    }
}
