using UnityEngine;
using System.Collections;

public class SpawnedObjectManager : MonoBehaviour {

	Rigidbody2D rb;
	public float moveSpeed;

	// Use this for initialization
	void Awake() 
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Start () 
	{
		rb.velocity = new Vector2(moveSpeed, 0);
	}

	void OnTriggerEnter2D(Collider2D death)
	{
		if(death.gameObject.tag == ("KillIt"))
			Destroy(this.gameObject);
	}
}
