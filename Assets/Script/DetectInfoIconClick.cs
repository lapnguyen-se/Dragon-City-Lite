using UnityEngine;
using System.Collections;

public class DetectInfoIconClick : MonoBehaviour {

	
	public GameObject infoSymbol;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown ()
	{
		Vector3 position ;
		position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));
		position.z = gameObject.transform.position.z;
		GameObject clone = Instantiate (infoSymbol, position, Quaternion.identity) as GameObject;
	}
}
