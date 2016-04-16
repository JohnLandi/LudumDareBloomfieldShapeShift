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
			if (guiTexture.HitTest(touch.position) && Input.GetTouch(0).phase == TouchPhase.Began)
			{
				guiTexture.texture = buttonDown;
				//button clicked down texture change
			}
			//if you touch this then let go....
			else if (guiTexture.HitTest(touch.position) && Input.GetTouch(0).phase == TouchPhase.Ended)
			{
				guiTexture.texture = buttonUp;
				//Button release up texture change
			}
		}
	}

	void OnMouseDown()
	{
				guiTexture.texture = buttonDown;
	}
	void OnMouseUp()
	{
				guiTexture.texture = buttonUp;
	}
}