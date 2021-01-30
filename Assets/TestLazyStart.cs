using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Immersal.AR;

public class TestLazyStart : MonoBehaviour
{
    public ARLocalizer hoge;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startARL());
    }

    IEnumerator startARL(){
        yield return new WaitForSeconds(3);

        Debug.Log("Hoge resume");
        hoge.Resume();

    }
}
