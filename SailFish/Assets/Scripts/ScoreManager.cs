using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public float score;
	public bool startScoreTime = false;

	Text text;

	void Awake () 
	{
		text = GetComponent<Text>();
		score = 0;
	}
	
	void Update () 
	{
		if (startScoreTime)
		{
		score = score + Time.deltaTime;
		}
		text.text = "Score: " + score;
	}
}
