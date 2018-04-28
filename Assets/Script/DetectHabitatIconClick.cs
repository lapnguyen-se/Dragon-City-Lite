using UnityEngine;
using System.Collections;

public class DetectHabitatIconClick : MonoBehaviour {
	private GameObject clone;
	public GameObject Sea;
	public GameObject Nature;
	public GameObject Electric;
	// Use this for initialization
	void Start () {
	
	}
	void OnMouseDown ()
	{
		if (gameObject.name == "SeaIcon") {
			
			//.Instantiate(aaa);
			//GameObject clone=Instantiate(Building, Building.transform.position, Building.transform.rotation) as GameObject;
			Vector3 tmp = Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
			tmp.z = Sea.transform.position.z;
			clone = Instantiate (Sea, tmp, Sea.transform.rotation) as GameObject;
		}
		
		if (gameObject.name == "NatureIcon") {
			
			//.Instantiate(aaa);
			//GameObject clone=Instantiate(Building, Building.transform.position, Building.transform.rotation) as GameObject;
			Vector3 tmp = Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
			tmp.z = Nature.transform.position.z;
			clone = Instantiate (Nature, tmp, Nature.transform.rotation) as GameObject;
		}
		
		if (gameObject.name == "ElectricIcon") {
			
			//.Instantiate(aaa);
			//GameObject clone=Instantiate(Building, Building.transform.position, Building.transform.rotation) as GameObject;
			Vector3 tmp = Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
			tmp.z = Electric.transform.position.z;
			clone = Instantiate (Electric, tmp, Electric.transform.rotation) as GameObject;
		}
		GameObject other= GameObject.Find("GUIController");
		GuiController guiController = other.GetComponent ("GuiController") as GuiController;
		guiController.CloseAll();
		
	}
	// Update is called once per frame
	void Update () {
	
	}
}
