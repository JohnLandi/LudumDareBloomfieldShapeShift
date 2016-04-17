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
		m_Credits.SetActive(false);
		m_MainMenu.SetActive(false);
		m_Retry.SetActive(false);
		m_Rules.SetActive(false);

		gc.m_running = true;
	}

	public void MainMenu()
	{
		m_Credits.SetActive(false);
		m_MainMenu.SetActive(true);
		m_Retry.SetActive(false);
		m_Rules.SetActive(false);
	}

	public void Rules()
	{
		m_Credits.SetActive(false);
		m_MainMenu.SetActive(false);
		m_Retry.SetActive(false);
		m_Rules.SetActive(true);
	}

	public void Credits()
	{
		m_Credits.SetActive(true);
		m_MainMenu.SetActive(false);
		m_Retry.SetActive(false);
		m_Rules.SetActive(false);
	}

	public void Retry()
	{
		m_Credits.SetActive(false);
		m_MainMenu.SetActive(false);
		m_Retry.SetActive(true);
		m_Rules.SetActive(false);

		gc.m_running = false;
	}
		
	public void Quit()
	{
		Application.Quit();
	}
}