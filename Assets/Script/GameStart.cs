using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameStart : MonoBehaviour
{
    private GameObject StartTxt;
    private void Start()
    {
        StartTxt = gameObject.transform.GetChild(0).gameObject;
    }

    public void ClickButton()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        Debug.Log("GaneStart");
    }
}