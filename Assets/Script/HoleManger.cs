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
            holes.Add(transform.GetChild(i).gameObject); //从场景里获取名字为指定命名的物体并添加到Holes列表中
            Debug.Log(holes[i].name);
        }
    }


    void Update()
    {
        GameObject mole = new GameObject();


        showHole(mole);
    }

    private float delayShowTime;
    void showHole(GameObject mole)
    {
        delayShowTime += Time.deltaTime;
        if (delayShowTime > 1.0f)
        {

            Debug.Log(Time.time);
            var random = Random.Range(0, holes.Count); //获取到一个随机数，数值最大值为holes的长度
            mole.SetActive(false);
            //遍历随机到的hole的子物体，如果名字为tex_mole 则把他显示出来

            for (int i = 0; i < holes[random].transform.childCount; i++)
            {
                if (holes[random].transform.GetChild(i).name == "tex_mole")
                {
                    mole = holes[random].transform.GetChild(i).gameObject; //获取到Hole下第0个物体
                }
            }
            mole.SetActive(true);
            delayShowTime = 0.0f;
        }
    }
}