using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	//use this where you want to save
	/*
	 	PlayerPrefs.SetInt("ppHighScore", (int)highScore); highScore should be an int regular int that you declare on this script
		PlayerPrefs.Save();
	 */

	// Use this for initialization
	void Start () 
	{
		PlayerPrefs.GetInt("ppHighScore");
		highScore = PlayerPrefs.GetInt ("ppHighScore");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
