using UnityEngine;
using System.Collections;

public class MoveIcon : MonoBehaviour {
	private Vector3 position;
	private GameObject tmpGameObject=null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));
		position.z = gameObject.transform.position.z;
		gameObject.transform.position = position;
	}
	void OnTriggerEnter2D (Collider2D other)
	{

		tmpGameObject = other.gameObject;
	} 
	void OnTriggerExit2D (Collider2D other)
	{
		tmpGameObject = null;
	}
	
	void OnTriggerStay2D (Collider2D other)
	{
		tmpGameObject = other.gameObject;
	}
	void OnMouseDown ()
	{
		if (tmpGameObject != null && tmpGameObject.tag=="Building") {
			MoveBuilding moveBuildingScript = tmpGameObject.GetComponent ("MoveBuilding") as MoveBuilding;
			moveBuildingScript.canMoveAgain=true;
			moveBuildingScript.isMoving=true;
			moveBuildingScript.Ground.SetActive(true);
			moveBuildingScript.beforeMovingPosition=moveBuildingScript.transform.position;
			moveBuildingScript.canBuild=true;
		} else {

		}
		Destroy (gameObject);
	}
}
