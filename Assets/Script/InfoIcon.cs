using UnityEngine;
using System.Collections;

public class InfoIcon : MonoBehaviour {
	private GameObject tmpGameObject=null;
	private Vector3 position;
	public GameObject farmBuildingWindow;
	public GameObject decorationBuildingWindow;
	public GameObject habitatBuildingWindow;
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
			Time.timeScale = 0;
			if(tmpGameObject.name=="Farm")
			{
			GameObject clone = Instantiate (farmBuildingWindow, farmBuildingWindow.transform.position, Quaternion.identity) as GameObject;
			}
			if(tmpGameObject.name=="SeaHa"||tmpGameObject.name=="NatureHa"||tmpGameObject.name=="ElectricHa")
			{
				GameObject clone = Instantiate (habitatBuildingWindow, habitatBuildingWindow.transform.position, Quaternion.identity) as GameObject;
			}
			if(tmpGameObject.name=="Flower"||tmpGameObject.name=="FlowerBox"||tmpGameObject.name=="SwimmingHole")
			{
				GameObject clone = Instantiate (decorationBuildingWindow, decorationBuildingWindow.transform.position, Quaternion.identity) as GameObject;
			}


		}
		Destroy (gameObject);
	}
}
