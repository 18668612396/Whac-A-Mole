using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AddGrade : MonoBehaviour
{
    public static int grade = 0;

    private void Start()
    {
        grade = 0;
    }

    public static  void AddGradeNumber(int grades)
    {
        grade += grades;
        GameObject.Find("Grade").GetComponent<TextMesh>().text = grade.ToString();
        Debug.Log(grade);

        switch (grade)
        {
            case < 0:
                GameObject.Find("YouLose").GetComponent<MeshRenderer>().enabled = true;
                Debug.Log("test");
                Time.timeScale = 0f;
                break;
            case 20:
                GameObject.Find("YouWin").GetComponent<MeshRenderer>().enabled = true;
                Time.timeScale = 0f;
                break;
        }
    }
}