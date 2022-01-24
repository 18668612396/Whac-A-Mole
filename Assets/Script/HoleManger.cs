using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;


public class HoleManger : MonoBehaviour
{
    public List<GameObject> holes = new List<GameObject>();
    private int childrenCount; //存储子节点的数量

    void Start()
    {
        childrenCount = gameObject.transform.childCount; //获取子节点的数量
        for (int i = 0; i < childrenCount; i++)
        {
            holes.Add(transform.GetChild(i).gameObject); //将获取到的”坑“的GameObject存入holes列表中
        }
    }


    void Update()
    {
        OnMoleShow();
    }

    private float tempShowTime;
    private GameObject moleControl;

    private bool moleState;

    void OnMoleShow()
    {
        if (moleState != true)
        {
            var random = Random.Range(0, holes.Count);
            tempShowTime += Time.deltaTime;
            if (tempShowTime > 1.0f)
            {
                moleControl = holes[random].transform.GetChild(0).gameObject;
                moleControl.SetActive(true);
                
                moleState = true;
            }
        }
    }
}