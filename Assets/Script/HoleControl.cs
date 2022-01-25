using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class HoleControl : MonoBehaviour
{
    public GameObject moleAudio;
    private GameObject mole;
    private GameObject moleParticle;
    public bool moleState;

    private void Start()
    {
        mole = transform.GetChild(0).gameObject;
        moleParticle = transform.GetChild(2).gameObject;
    }

    private float moleUnShowTime;

    private void Update()
    {
        moleState = mole.activeSelf;
        if (moleState)
        {
            moleUnShowTime += Time.deltaTime;
            if (moleUnShowTime > 3)
            {
                mole.SetActive(false);
                moleUnShowTime = 0;
                AddGrade.AddGradeNumber(-1);
            }
        }
    }

    private float moleParticleState;

    public void MoleShow()
    {
        moleParticleState += Time.deltaTime;
        if (mole.activeSelf != true)
        {
            mole.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (mole.activeSelf == true)
        {
            moleParticle.GetComponent<ParticleSystem>().Play();
            mole.SetActive(false);
            AddGrade.AddGradeNumber(1);
            moleAudio.GetComponent<AudioSource>().Play();
            
        }
    }

}