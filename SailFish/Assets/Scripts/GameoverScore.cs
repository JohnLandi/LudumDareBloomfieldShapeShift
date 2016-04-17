using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameoverScore : MonoBehaviour {

	public ScoreManager refScore;
	Text text;

	void Awake () 
	{
		text = GetComponent<Text>();
	}

	void Update () 
	{
		text.text = "You travelled a total distance of " + Mathf.Floor(refScore.score) + " feet!!";
	}
}