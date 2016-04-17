//Controls Gameplay objects and script actions
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	public MenuController mc;

	public ScoreManager sm;

	//Material offset speed is divided by this number
	public static float BackgroundMaterialOffsetSpeed = 4;
	public float MaterialSpeedOverride;

	Spawn spawn;

	public float TimeBetweenSpawn;
	private float timer;

	public bool m_running = false;
	public AudioSource sound;
	public AudioSource gameplayMusic;
	public AudioSource mainMenuMusic;
	public AudioSource creditsMusic;

	public AudioClip m_MenuPress;
	public AudioClip m_Eat;
	public AudioClip m_GotHit;

	public float health = 100;
	public Image healthBar;


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
		sound = GetComponent<AudioSource>();
		
		//	this shit below needs to be in the start for player prefs
		//	PlayerPrefs.GetInt("ppHighScore");
		//	highScore = PlayerPrefs.GetInt ("ppHighScore");
	}
	
	//Runs and Resets timer, initiates Spawner() from Spawn script
	void Update () 
	{		
		BackgroundMaterialOffsetSpeed = MaterialSpeedOverride;

		if(m_running == true)
		{
			timer = timer - Time.deltaTime;
			if(timer <= 0)
			{
				spawn.Spawner();
				timer = TimeBetweenSpawn;
			}
		}
		else
		{
			timer = 3;
		}


		healthBar.fillAmount = health / 100;
		//Health Rules
		if (health > 100)
			health = 100;
		if (health <= 0)
		{
			Debug.Log ("Player is dead");
			sm.startScoreTime = false;
			mc.Retry();
			health = 100;
			//trigger death animation. end game run
		}
	}

	public void PlayMenuButtonSound()
	{
		sound.PlayOneShot(m_MenuPress, 1);
		Debug.Log("Audio is playing bitch");
	}

	public void PlayEatSound()
	{
		sound.PlayOneShot(m_Eat, 1);
		Debug.Log("Audio is playing bitch");
	}

	public void PlayHitSound()
	{
		sound.PlayOneShot(m_GotHit, 1);
		Debug.Log("Audio is playing bitch");
	}

	public void PlayGamplayMusic()
	{
		gameplayMusic.Play();
	}

	public void StopGamplayMusic()
	{
		gameplayMusic.Stop();
	}

	public void PlayMainMenuMusic()
	{
		mainMenuMusic.Play();
	}

	public void StopMainMenuMusic()
	{
		mainMenuMusic.Stop();
	}

	public void PlayCreditsMusic()
	{
		creditsMusic.Play();
	}

	public void StopCreditsMusic()
	{
		creditsMusic.Stop();
	}
}
