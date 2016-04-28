using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {
	private float crosshairSize;
	private Texture2D crosshairTexture;
	private Rect crosshairRect;

	// Use this for initialization
	void Start () {
		crosshairSize = Screen.width * 0.06f;
		crosshairTexture = Resources.Load ("Textures/crosshair") as Texture2D;
		crosshairRect = new Rect (Screen.width / 2 - crosshairSize / 2, Screen.height / 2 - crosshairSize / 2, crosshairSize, crosshairSize);
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.DrawTexture (crosshairRect, crosshairTexture);

	}
}
