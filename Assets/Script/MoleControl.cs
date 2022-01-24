using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoleControl : MonoBehaviour
{
    public int state;

    // Start is called before the first frame update
    public void Start()
    {
        
    }
    private float tempUnShowTime;
    private void Update()
    {
        tempUnShowTime += Time.deltaTime;
        if (tempUnShowTime > 2.0f)
        {
            gameObject.SetActive(false);
        }
    }



    void UnShow()
    {
        gameObject.SetActive(false);
    }
    void OnDest()
    {
        gameObject.SetActive(false);
    }
    
    
    // public MoleControl(int state)
    // {
    //     switch (state)
    //     {
    //         case 1:
    //             OnShow();
    //             break;
    //         case 2 :
    //             UnShow();
    //             break;
    //         case 3 :
    //             OnDest();
    //             break;
    //     }
    // }
    
}