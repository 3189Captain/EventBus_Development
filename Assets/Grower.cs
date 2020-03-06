using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grower : MonoBehaviour
{
    private bool mIsQuitting;

    private void OnEnable()
    {
        EventBus.StartListening("Grow", Grow);
    }

    private void OnApplicationQuit()
    {
        mIsQuitting = true;
    }

    private void OnDisable()
    {
        if (mIsQuitting == false)
        {
            EventBus.StopListening("Grow", Grow);
        }
    }

    void Grow()
    {
        Debug.Log("Received Grow event: growing!");
        this.gameObject.transform.localScale += new Vector3(0, 1, 0);
    }
}
