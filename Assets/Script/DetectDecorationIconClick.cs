using UnityEngine;
using System.Collections;

public class DetectDecorationIconClick : MonoBehaviour
{
	private GameObject clone;
	public GameObject FlowerBox;
	public GameObject Flower;
	public GameObject SwimmingHoleIcon;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	void OnMouseDown ()
	{
		if (gameObject.name == "FlowerBoxIcon") {

			//.Instantiate(aaa);
			//GameObject clone=Instantiate(Building, Building.transform.position, Building.transform.rotation) as GameObject;
			Vector3 tmp = Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
			tmp.z = FlowerBox.transform.position.z;
			clone = Instantiate (FlowerBox, tmp, FlowerBox.transform.rotation) as GameObject;
		}

		if (gameObject.name == "FlowerIcon") {
			
			//.Instantiate(aaa);
			//GameObject clone=Instantiate(Building, Building.transform.position, Building.transform.rotation) as GameObject;
			Vector3 tmp = Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
			tmp.z = Flower.transform.position.z;
			clone = Instantiate (Flower, tmp, Flower.transform.rotation) as GameObject;
		}

		if (gameObject.name == "SwimmingHoleIcon") {
			
			//.Instantiate(aaa);
			//GameObject clone=Instantiate(Building, Building.transform.position, Building.transform.rotation) as GameObject;
			Vector3 tmp = Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
			tmp.z = SwimmingHoleIcon.transform.position.z;
			clone = Instantiate (SwimmingHoleIcon, tmp, SwimmingHoleIcon.transform.rotation) as GameObject;
		}
		GameObject other= GameObject.Find("GUIController");
		GuiController guiController = other.GetComponent ("GuiController") as GuiController;
		guiController.CloseAll();
		
	}
	// Update is called once per frame
	void Update ()
	{
	
	}
}
