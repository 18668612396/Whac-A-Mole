using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleControl : MonoBehaviour
{
    // Start is called before the first frame update

    public MoleControl(bool active)
    {
           gameObject.SetActive(active);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
