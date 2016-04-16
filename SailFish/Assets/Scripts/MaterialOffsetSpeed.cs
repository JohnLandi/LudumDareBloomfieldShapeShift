using UnityEngine;
using System.Collections;

public class MaterialOffsetSpeed : MonoBehaviour {

	public Material backgroundMaterial;
	public float speedModifier = 1;

	void Update () 
	{
		backgroundMaterial.mainTextureOffset = backgroundMaterial.mainTextureOffset + new Vector2 ((Time.deltaTime / (GameController.BackgroundMaterialOffsetSpeed / speedModifier)), 0);
	}
}
