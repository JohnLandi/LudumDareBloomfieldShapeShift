﻿//Touch and mouse controls to move player
using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	public Transform[] playerPositions;
	public int positionChange = 1;
	public float speed;


	void Update () 
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit, 30))
		{
			//mouse commands to set player to different array positions
			if(Input.GetMouseButtonUp(0) && hit.transform.tag == "Sky")
			{
					positionChange = 0;
			}
			if(Input.GetMouseButtonUp(0) && hit.transform.tag == "Earth")
			{
					positionChange = 1;
			}
			if(Input.GetMouseButtonUp(0) && hit.transform.tag == "Water")
			{
					positionChange = 2;
			}
			//Touch commands to set player to different array positions
			foreach (Touch touch in Input.touches)
			{
				if(Input.GetTouch(0).phase == TouchPhase.Began && hit.transform.tag == "Sky")
				{
					positionChange = 0;
				}
				if(Input.GetTouch(0).phase == TouchPhase.Began && hit.transform.tag == "Earth")
				{
					positionChange = 1;
				}
				if(Input.GetTouch(0).phase == TouchPhase.Began && hit.transform.tag == "Water")
				{
					positionChange = 2;
				}
			}
		}
		//Moves the player toward set position
		float step = speed * Time.deltaTime;
		transform.position = Vector2.MoveTowards (transform.position, playerPositions[positionChange].position, step);
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == ("Damage"))
		{
			Debug.Log("Taking Damage");
		//lower health bar or diet, etc
		}
		if(other.gameObject.tag == ("Heal"))
		{	
			Debug.Log("Receiving Health");
		//Raise health bar or diet, etc
		}
	}
}