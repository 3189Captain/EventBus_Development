using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private bool mIsQuitting;

    private void OnEnable()
    {
        EventBus.StartListening("Change", ChangeColor);
    }

    private void OnApplicationQuit()
    {
        mIsQuitting = true;
    }

    private void OnDisable()
    {
        if (mIsQuitting == false)
        {
            EventBus.StopListening("Change", ChangeColor);
        }
    }

    void ChangeColor()
    {
        Debug.Log("Received change event: changing color!");
        this.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
