using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddGrade : MonoBehaviour
{
    public static int grade = 0;
    
    public static float gameHard;//游戏难度
    private void Start()
    {
        grade = 0;
    }

    public static void AddGradeNumber(int number)
    {
        grade += number;
        GameObject.Find("GradeNumber").GetComponent<Text>().text = grade.ToString();

        switch (grade)
        {
            case < 0:
                GameObject.Find("YouLose").GetComponent<Text>().enabled = true;

                GameOver();
                break;
            case 99:
                GameObject.Find("YouWin").GetComponent<Text>().enabled = true;

                GameOver();
                break;
        }
    }

    static void GameOver()
    {
        Time.timeScale = 0.0f;
    }
}