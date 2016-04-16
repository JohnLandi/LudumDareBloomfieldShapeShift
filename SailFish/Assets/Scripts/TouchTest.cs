using UnityEngine;
using System.Collections;

public class TouchTest : MonoBehaviour {

	public Texture buttonUp, buttonDown, Locked;


	// Update is called once per frame
	void Update () 
	{


		//Touch controls
		foreach (Touch touch in Input.touches)
		{
			//if this is touched/held down....
			if (GetComponent<GUITexture>().HitTest(touch.position) && Input.GetTouch(0).phase == TouchPhase.Began)
			{
				GetComponent<GUITexture>().texture = buttonDown;
				//button clicked down texture change
			}
			//if you touch this then let go....
			else if (GetComponent<GUITexture>().HitTest(touch.position) && Input.GetTouch(0).phase == TouchPhase.Ended)
			{
				GetComponent<GUITexture>().texture = buttonUp;
				//Button release up texture change
			}
		}
	}

	void OnMouseDown()
	{
				GetComponent<GUITexture>().texture = buttonDown;
	}
	void OnMouseUp()
	{
				GetComponent<GUITexture>().texture = buttonUp;
	}
}