//Controls Gameplay objects and script actions
using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	//Material offset speed is divided by this number
	public static float BackgroundMaterialOffsetSpeed = 4;
	public float MaterialSpeedOverride;

	Spawn spawn;

	public float TimeBetweenSpawn;
	private float timer;


	//use this where you want to save
	/*
	 	PlayerPrefs.SetInt("ppHighScore", (int)highScore); highScore should be an int regular int that you declare on this script
		PlayerPrefs.Save();
	 */

	//Get Components
	void Awake()
	{
		spawn = GetComponent<Spawn>();
	}

	//Begin timer
	void Start () 
	{
		timer = TimeBetweenSpawn;
		
		//	this shit below needs to be in the start for player prefs
		//	PlayerPrefs.GetInt("ppHighScore");
		//	highScore = PlayerPrefs.GetInt ("ppHighScore");
	}
	
	//Runs and Resets timer, initiates Spawner() from Spawn script
	void Update () 
	{		
		BackgroundMaterialOffsetSpeed = MaterialSpeedOverride;

		timer = timer - Time.deltaTime;
		if(timer <= 0)
		{
			spawn.Spawner();
			timer = TimeBetweenSpawn;
		}
	}
}
