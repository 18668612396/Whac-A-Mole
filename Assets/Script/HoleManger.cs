using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;


public class HoleManger : MonoBehaviour
{
    private List<GameObject> holes = new List<GameObject>(); //声明一个存储洞的数组
    private float gameHard;
    void Start()
    {
        var childrenCount = gameObject.transform.childCount; //获取子节点的数量
        for (int i = 0; i < childrenCount; i++)
        {
            holes.Add(transform.GetChild(i).gameObject); //将获取到的”坑“的GameObject存入holes列表中
        }
    }

    private GameObject hole;//洞的GameObject
    private float moleShowTime;//控制间隔触发所使用的临时变量
    void Update()
    {
        var random = Random.Range(0, holes.Count);//随机一个整数，用来控制显示某个洞
        hole = holes[random].gameObject;//获得随机的一个洞

        moleShowTime += Time.deltaTime;//更新临时时间变量
        if (!hole.GetComponent<HoleControl>().isActiveAndEnabled)
        {
            if (moleShowTime > AddGrade.gameHard)
            {
                hole.GetComponent<HoleControl>().enabled = true;//将脚本打开
                moleShowTime = 0;//重置临时时间变量
            }
        }
    }
}