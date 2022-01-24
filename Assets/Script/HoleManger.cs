using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleManger : MonoBehaviour
{
    private List<GameObject> holeList = new List<GameObject>();

    private int childrenCount;
    // Start is called before the first frame update
    void Start()
    {
        holeList = GetComponentInChildren<List<GameObject>>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
