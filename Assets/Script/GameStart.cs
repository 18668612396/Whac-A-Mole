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

    public void EazyClickButton()
    {
        AddGrade.gameHard = 1.0f;
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
        Debug.Log("GaneStart");
    }
    
    public void HardClickButton()
    {
        AddGrade.gameHard = 0.5f;
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
        Debug.Log("GaneStart");
    }

    public void BackGameStart()
    {
        AddGrade.gameHard = 1f;
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
        Debug.Log("GameBack");
    }
}