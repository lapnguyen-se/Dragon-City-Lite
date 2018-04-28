using UnityEngine;
using System.Collections;

public class DetectMoveIconClick : MonoBehaviour {
//	private bool isUsing = false;

	public GameObject moveSymbol;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown ()
	{
		Vector3 tmp = moveSymbol.transform.position;

		GameObject clone = Instantiate (moveSymbol, tmp, Quaternion.identity) as GameObject;
	}
}
