using UnityEngine;
using System.Collections;

public class PauseGameByClick : MonoBehaviour {
	private bool isPausing=false;
	public Texture2D playing;
	public Texture2D pausing;
	// Use this for initialization
	void Start () {
		gameObject.guiTexture.texture=playing;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseEnter()
	{
		SoundEffectsHelper.Instance.MouseEnterSound ();
	}
	void OnMouseDown()
	{
		SoundEffectsHelper.Instance.MouseClickSound ();
		if (isPausing == true) {
			Time.timeScale = 1;
			isPausing=false;
			gameObject.guiTexture.texture=playing;
		} else {
			Time.timeScale = 0;
			isPausing=true;
			gameObject.guiTexture.texture=pausing;
		}
	}
}
