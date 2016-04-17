using UnityEngine;
using System.Collections;

public class MaterialOffsetSpeed : MonoBehaviour {

	public Material backgroundMaterial;
	public float speedModifier = 1;

	public GameController gc;

	void Update () 
	{
		if(gc.m_running == true)
		{
			backgroundMaterial.mainTextureOffset = backgroundMaterial.mainTextureOffset + new Vector2 ((Time.deltaTime / (GameController.BackgroundMaterialOffsetSpeed / speedModifier)), 0);
		}
	}
}
