using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class HoleControl : MonoBehaviour
{
    private List<GameObject> monsters = new List<GameObject>(); //声明一个怪物的数组，用来储存所有的怪物
    private List<GameObject> effects = new List<GameObject>();
    private GameObject currMonster;

    private void OnEnable()
    {
        var monsterObject = gameObject.transform.GetChild(0); //获取Monster节点
        var monsterCount = monsterObject.transform.childCount; //获取Monster节点的子节点数量
        //将所有的怪物储存到Monsters列表内
        for (int i = 0; i < monsterCount; i++)
        {
            monsters.Add(monsterObject.GetChild(i).gameObject);
        }
        //将所有的特效储存到effects列表内
        var effectObject = gameObject.transform.GetChild(1);
        var effectCount = effectObject.transform.childCount;
        for (int i = 0; i < effectCount; i++)
        {
            effects.Add(effectObject.GetChild(i).gameObject);
        }
        //随机从monsters里捞出一个怪物并显示他
        currMonster = monsters[Random.Range(0, monsters.Count)];
        if (currMonster.activeSelf != true)
        {
            currMonster.SetActive(true);
        }

        Invoke("MonsterFlee", 3); //当怪物显示3秒之后 怪物将会逃走
    }

    private void OnMouseDown()
    {
        if (currMonster.activeSelf != false)
        {
            //判断杀死了什么怪物，造成不同的反馈
            switch (currMonster.name)
            {
                case "Diglett":
                    effects[0].GetComponent<ParticleSystem>().Play();
                    effects[0].GetComponent<AudioSource>().Play();
                    currMonster.SetActive(false); //先关闭怪物的显示
                    Debug.Log("杀死了地鼠");
                    break;
                case "Boom":
                    effects[1].GetComponent<ParticleSystem>().Play();
                    effects[1].GetComponent<AudioSource>().Play();
                    currMonster.SetActive(false); //先关闭怪物的显示
                    Debug.Log("杀死了炸弹");
                    break;
                case "Deadman":
                    Debug.Log("点到了地桩");
                    break;
            }
        }
    }

    void MonsterDie()
    {
        
    }

    void MonsterFlee()
    {
        currMonster.SetActive(false); //先关闭怪物的显示
        Invoke("CloseScript", 1); //怪物关闭1秒后关闭脚本 避免怪物消失后马上又出现产生的闪烁
    }

    void CloseScript()
    {
        enabled = false;
    }
}