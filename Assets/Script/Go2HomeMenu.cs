using UnityEngine;
using System.Collections;

public class Go2HomeMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseEnter() {
		SoundEffectsHelper.Instance.MouseEnterSound ();
		
	}
	void OnMouseDown()
	{
		SoundEffectsHelper.Instance.MouseClickSound ();
		Application.LoadLevel ("scene_InHomeMenu");
	}
}
