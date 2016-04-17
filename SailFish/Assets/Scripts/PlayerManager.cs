//Touch and mouse controls to move player
using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	public Transform[] playerPositions;
	public int positionChange = 1;
	public float speed;

	Animator anim;
	ParticleSystem ps;

	public GameController gc;

	void Awake()
	{
		anim = GetComponent<Animator>();
		ps = GetComponent<ParticleSystem>();
	}

	void Update () 
	{
		if(gc.m_running == true)
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit, 30))
			{
				//mouse commands to set player to different array positions
				if(Input.GetMouseButtonUp(0) && hit.transform.tag == "Sky")
				{
						positionChange = 0;
						anim.SetInteger ("Shapeshift", 0);
					ps.Play();
				}
				if(Input.GetMouseButtonUp(0) && hit.transform.tag == "Earth")
				{
						positionChange = 1;
						anim.SetInteger ("Shapeshift", 1);
					ps.Play();
				}
				if(Input.GetMouseButtonUp(0) && hit.transform.tag == "Water")
				{
						positionChange = 2;
						anim.SetInteger ("Shapeshift", 2);
					ps.Play();
				}
				//Touch commands to set player to different array positions
				foreach (Touch touch in Input.touches)
				{
					if(Input.GetTouch(0).phase == TouchPhase.Began && hit.transform.tag == "Sky")
					{
						positionChange = 0;
						anim.SetInteger ("Shapeshift", 0);
						ps.Play();
					}
					if(Input.GetTouch(0).phase == TouchPhase.Began && hit.transform.tag == "Earth")
					{
						positionChange = 1;
						anim.SetInteger ("Shapeshift", 1);
						ps.Play();
					}
					if(Input.GetTouch(0).phase == TouchPhase.Began && hit.transform.tag == "Water")
					{
						positionChange = 2;
						anim.SetInteger ("Shapeshift", 2);
						ps.Play();
					}
				}
			}
		}
		//Moves the player toward set position
		float step = speed * Time.deltaTime;
		transform.position = Vector2.MoveTowards (transform.position, playerPositions[positionChange].position, step);




	}


	//collision for health and damage modifiers
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == ("Damage"))
		{
			Debug.Log("Taking Damage");
			gc.health -= 35;
			gc.PlayHitSound();
		//lower health bar or diet, etc
		}
		if(other.gameObject.tag == ("Heal"))
		{	
			gc.health += 35;
			Debug.Log("Receiving Health");
			gc.PlayEatSound();
		//Raise health bar or diet, etc
		}
	}
}