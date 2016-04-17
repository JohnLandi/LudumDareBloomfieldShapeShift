using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class MenuController: MonoBehaviour
{

	public GameController gc;
	public ScoreManager sm;

	public GameObject m_MainMenu;
	public GameObject m_Credits;
	public GameObject m_Rules;
	public GameObject m_Retry;
	public GameObject HUD1;
	public GameObject HUD2;


	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{
		
	}

	public void ToGame()
	{
		gc.PlayMenuButtonSound();
		m_Credits.SetActive(false);
		m_MainMenu.SetActive(false);
		m_Retry.SetActive(false);
		m_Rules.SetActive(false);

		gc.PlayGamplayMusic();
		gc.StopMainMenuMusic();
		gc.StopCreditsMusic();

		HUD1.SetActive(true);
		HUD2.SetActive(true);

		gc.m_running = true;

		sm.startScoreTime = true;
	}

	public void MainMenu()
	{
		gc.PlayMenuButtonSound();
		m_Credits.SetActive(false);
		m_MainMenu.SetActive(true);
		m_Retry.SetActive(false);
		m_Rules.SetActive(false);

		gc.StopGamplayMusic();
		gc.PlayMainMenuMusic();
		gc.StopCreditsMusic();
	}

	public void Rules()
	{
		gc.PlayMenuButtonSound();
		m_Credits.SetActive(false);
		m_MainMenu.SetActive(false);
		m_Retry.SetActive(false);
		m_Rules.SetActive(true);

		gc.StopGamplayMusic();
		gc.StopMainMenuMusic();
		gc.PlayCreditsMusic();
	}

	public void Credits()
	{
		gc.PlayMenuButtonSound();
		m_Credits.SetActive(true);
		m_MainMenu.SetActive(false);
		m_Retry.SetActive(false);
		m_Rules.SetActive(false);

		gc.StopGamplayMusic();
		gc.StopMainMenuMusic();
		gc.PlayCreditsMusic();
	}

	public void Retry()
	{
		//gc.PlayMenuButtonSound();
		m_Credits.SetActive(false);
		m_MainMenu.SetActive(false);
		m_Retry.SetActive(true);
		m_Rules.SetActive(false);

		HUD1.SetActive(false);
		HUD2.SetActive(false);

		gc.m_running = false;
	}
		
	public void Quit()
	{
		gc.PlayMenuButtonSound();
		Application.Quit();
	}
}


