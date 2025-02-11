﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    private bool mIsQuitting;

    private void OnEnable()
    {
        EventBus.StartListening("Shoot", ShootCannon);
    }

    private void OnApplicationQuit()
    {
        mIsQuitting = true;
    }

    private void OnDisable()
    {
        if(mIsQuitting == false)
        {
            EventBus.StopListening("Shoot", ShootCannon);
        }
    }

    void ShootCannon()
    {
        Debug.Log("Received shoot event: shooting cannon!");
    }
}
