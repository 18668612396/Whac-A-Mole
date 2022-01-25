using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;


public class HoleManger : MonoBehaviour
{
    private List<GameObject> holes = new List<GameObject>();
    private int childrenCount; //存储子节点的数量

    void Start()
    {
        childrenCount = gameObject.transform.childCount; //获取子节点的数量
        for (int i = 0; i < childrenCount; i++)
        {
            holes.Add(transform.GetChild(i).gameObject); //将获取到的”坑“的GameObject存入holes列表中
        }
    }

    private GameObject hole;
    private float moleShowTime;

    void Update()
    {
        var random = Random.Range(0, holes.Count);
        hole = holes[random].gameObject;

        moleShowTime += Time.deltaTime;
        if (!hole.GetComponent<HoleControl>().moleState)
        {
            if (moleShowTime > 1.0f)
            {
                hole.GetComponent<HoleControl>().MoleShow();
                moleShowTime = 0;
            }
        }
    }
    private float tempShowTime;
    private bool moleState;
}