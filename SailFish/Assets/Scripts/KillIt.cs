using UnityEngine;
using System.Collections;

public class KillIt : MonoBehaviour {

	public float timeBeforeDeath = 5;

	// Update is called once per frame
	void Update () {
		timeBeforeDeath = timeBeforeDeath - Time.deltaTime;
		if(timeBeforeDeath <= 0)
		{
			Destroy(this.gameObject);
		}
	}
}
