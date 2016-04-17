using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class MenuController: MonoBehaviour
{

	public GameController gc;

	public GameObject m_MainMenu;
	public GameObject m_Credits;
	public GameObject m_Rules;
	public GameObject m_Retry;


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

		gc.m_running = true;
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
		gc.PlayMenuButtonSound();
		m_Credits.SetActive(false);
		m_MainMenu.SetActive(false);
		m_Retry.SetActive(true);
		m_Rules.SetActive(false);

		gc.m_running = false;
	}
		
	public void Quit()
	{
		gc.PlayMenuButtonSound();
		Application.Quit();
	}
}