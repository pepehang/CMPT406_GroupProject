﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBioLobby3Talk : MonoBehaviour
{
    public GameObject foreman;
    //public GameObject directionUnlocked;
    void Awake()
    {
        int var = PlayerPrefs.GetInt("ForeManLobby3");
        if (var == 1)
        {
            foreman.SetActive(false);
            GameObject varObject = GameObject.Find("Main Camera");
            varObject.GetComponent<TriggerWhenStart>().enabled = false;
            //directionUnlocked.SetActive(true);

        }
    }
}
