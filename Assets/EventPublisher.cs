using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPublisher : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            EventBus.TriggerEvent("Shoot");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            EventBus.TriggerEvent("Launch");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            EventBus.TriggerEvent("Change");
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            EventBus.TriggerEvent("Grow");
        }
    }
}
