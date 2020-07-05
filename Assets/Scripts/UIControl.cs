using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public int a = 100;
    // Start is called before the first frame update
    void Start()
    {
        ScalePlus();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScalePlus()
    {
        GameObject.FindWithTag("ARmodels").transform.localScale += new Vector3(a,a,a);
    }
}
