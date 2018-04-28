using UnityEngine;
using System.Collections;

public class PopupInfoWindow : MonoBehaviour {

	// Use this for initialization
	void Start () {

	
	}

	
	// Update is called once per frame
	void Update () {

	
	}
	void OnMouseDown()
	{
		Destroy (gameObject);
		Time.timeScale = 1;
	}
}
