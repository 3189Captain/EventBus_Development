using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
	private bool mIsQuitting;

	private void OnEnable()
	{
		EventBus.StartListening("Launch", LaunchRocket);
	}

	private void OnApplicationQuit()
	{
		mIsQuitting = true;
	}

	private void OnDisable()
	{
		EventBus.StopListening("Launch", LaunchRocket);
	}

	void LaunchRocket()
	{
		Debug.Log("Launch event received: Launching the rocket!");
		EventBus.StopListening("Launch", LaunchRocket);
		Debug.Log("The rocket exploded!!");
		Destroy(this.gameObject);
	}
}
