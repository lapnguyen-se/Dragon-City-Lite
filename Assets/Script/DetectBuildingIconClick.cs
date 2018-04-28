using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class DetectBuildingIconClick : MonoBehaviour
{
	public GameObject Building;
	private GameObject clone;
	private Vector3 position ;

	void Start ()
	{
	}

	void OnMouseDown ()
	{
		if (gameObject.name == "FarmIcon") {
			position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));
			position.z = Building.transform.position.z;
			clone = Instantiate (Building, position, Building.transform.rotation) as GameObject;
			GameObject tmp= GameObject.Find("GUIController");
			GuiController guiController = tmp.GetComponent ("GuiController") as GuiController;
			guiController.CloseAll();
		}

	}

	void Update ()
	{

	}
}
