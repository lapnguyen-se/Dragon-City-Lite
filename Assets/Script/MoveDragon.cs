using UnityEngine;
using System.Collections;

public class MoveDragon : MonoBehaviour
{
	private Vector3 screenPoint;
	private Vector3 offset;
	private Vector3 offsetforGroundCell;
	private bool canBuild = false ;
	private bool canMoveAgain = true;
	private Vector3 position;
	private GameObject BuildingDetect = null;
	private GameObject clone = null;

	public GameObject animationDark = null;
	public GameObject cannotBuidWindow=null;
	public GameObject noMoneyWindow=null;
	public GameObject numberDragonWindow=null;
	void Start ()
	{
		gameObject.renderer.sortingOrder = 1;
		gameObject.renderer.material.color = Color.red;


	}
	
	void Update ()
	{
		if (canMoveAgain == true) {
			position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));
			position.z = gameObject.transform.position.z;
			gameObject.transform.position = position;
		}
	}
	
	void OnMouseDown ()
	{

		if (canBuild == false) {
			Destroy (gameObject);
			 clone = Instantiate(cannotBuidWindow,cannotBuidWindow.transform.position,Quaternion.identity) as GameObject;
		}
		if (canBuild == true) {
			bool checkGold = false;
			GameObject scoreController = GameObject.Find ("ScoreController") as GameObject;
			ScoreController other = scoreController.GetComponent ("ScoreController") as ScoreController;

			MoveBuilding tmpMoveBuilding = BuildingDetect.GetComponent ("MoveBuilding") as MoveBuilding;
			if(tmpMoveBuilding.numberOfDragon==1)
			{
				clone = Instantiate(numberDragonWindow,cannotBuidWindow.transform.position,Quaternion.identity) as GameObject;
				Destroy (gameObject);
				return;
			}


			if (gameObject.name == "SeaDragon") {
				checkGold = other.CheckGoldIsOK (1500);
				if (checkGold == true) {
					other.DecreaseScore (1500);
					other.IncreaseDragon (1);

				} else {
					Debug.Log ("Khong du tien");
					Destroy (gameObject);
					 clone = Instantiate(noMoneyWindow,noMoneyWindow.transform.position,Quaternion.identity) as GameObject;

				}
			} else
				if (gameObject.name == "NatureDragon") {
				checkGold = other.CheckGoldIsOK (1800);
				if (checkGold == true) {
					other.DecreaseScore (1800);
					other.IncreaseDragon (1);
				} else {
					Debug.Log ("Khong du tien");
					Destroy (gameObject);
					 clone = Instantiate(noMoneyWindow,noMoneyWindow.transform.position,Quaternion.identity) as GameObject;
					
				}

			} else
				if (gameObject.name == "ElectricDragon") {
				checkGold = other.CheckGoldIsOK (3000);
				if (checkGold == true) {
					other.DecreaseScore (3000);
					other.IncreaseDragon (1);
				} else {
					Debug.Log ("Khong du tien");
					Destroy (gameObject);
					clone = Instantiate(noMoneyWindow,cannotBuidWindow.transform.position,Quaternion.identity) as GameObject;
				}
			}
			if (checkGold == true) {
				tmpMoveBuilding.numberOfDragon=tmpMoveBuilding.numberOfDragon+1;
				Vector3 tmp = gameObject.transform.position;
				tmp.z = 10;
				Destroy (gameObject);
				 clone = Instantiate (animationDark, tmp, Quaternion.identity) as GameObject;
			
				//MoveBuilding tmpMoveBuilding = BuildingDetect.GetComponent ("MoveBuilding") as MoveBuilding;
				tmpMoveBuilding.dragonAnimationBelong2Building=clone;
				tmpMoveBuilding.offsetDragonVSHabitat=tmpMoveBuilding.dragonAnimationBelong2Building.transform.position-BuildingDetect.transform.position;

			}

		}
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag != "Building")
			return;
		else {
			if (gameObject.name == "SeaDragon" && other.name == "SeaHa") {
				canBuild = true;
				gameObject.renderer.material.color = Color.green;
				BuildingDetect = other.gameObject;
			} else if (gameObject.name == "NatureDragon" && other.name == "NatureHa") {
				canBuild = true;
				gameObject.renderer.material.color = Color.green;
				BuildingDetect = other.gameObject;
			} else if (gameObject.name == "ElectricDragon" && other.name == "ElectricHa") {
				canBuild = true;
				gameObject.renderer.material.color = Color.green;
				BuildingDetect = other.gameObject;
			} else {
				canBuild = false;
				gameObject.renderer.material.color = Color.red;
			}


		}
		
	}
	
	void OnTriggerExit2D (Collider2D other)
	{
		canBuild = false;
		gameObject.renderer.material.color = Color.red;
		BuildingDetect = null;
		       
	}

	void OnTriggerStay2D (Collider2D other)
	{
		if (other.tag != "Building")
			return;
		else {
			if (gameObject.name == "SeaDragon" && other.name == "SeaHa") {
				canBuild = true;
				gameObject.renderer.material.color = Color.green;
				BuildingDetect = other.gameObject;
			} else if (gameObject.name == "NatureDragon" && other.name == "NatureHa") {
				canBuild = true;
				gameObject.renderer.material.color = Color.green;
				BuildingDetect = other.gameObject;
			} else if (gameObject.name == "ElectricDragon" && other.name == "ElectricHa") {
				canBuild = true;
				gameObject.renderer.material.color = Color.green;
				BuildingDetect = other.gameObject;
			} else {
				canBuild = false;
				gameObject.renderer.material.color = Color.red;
			}
		}
	}
	

}	
