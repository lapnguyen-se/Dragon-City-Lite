using UnityEngine;
using System.Collections.Generic;

public class MoveBuilding : MonoBehaviour
{
	private Vector3 screenPoint;
	private Vector3 offset;
	private Vector3 offsetforGroundCell;
	private Vector3 offsetFoodIcon;
	private Vector3 position;
	private bool canBuyFood = false;
	private bool isBuyingFood = false;
	private Vector3 originalFoodPosition;
	private GameObject clone = null;


	public GameObject foodControllerPrefab;
	public bool canBuild = true ;
	public bool canMoveAgain = true;
	public Vector3 offsetDragonVSHabitat = new Vector3 (0, 0, 0);
	public Vector3 beforeMovingPosition = new Vector3 (0, 0, 0);
	public GameObject Ground;
	public bool isMoving = false;
	public GameObject dragonAnimationBelong2Building = null;
	public GameObject cannotBuidWindow=null;
	public GameObject noMoneyWindow=null;
	public int numberOfDragon=0;

	void Start ()
	{

		offsetforGroundCell = gameObject.transform.position - Ground.transform.position;

	}

	void Update ()
	{
		if (canMoveAgain == true) {
			Ground.renderer.sortingOrder = 1;
			gameObject.renderer.sortingOrder = 1;
			position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));
			position.z = gameObject.transform.position.z;
			gameObject.transform.position = position;
			Ground.transform.position = gameObject.transform.position - offsetforGroundCell;
			if (canBuild == true)
				Ground.renderer.material.color = Color.green;
			else
				Ground.renderer.material.color = Color.red;
		}
		if (isMoving == true) {
			if (dragonAnimationBelong2Building != null) {
				dragonAnimationBelong2Building.transform.position = gameObject.transform.position+offsetDragonVSHabitat;
				dragonAnimationBelong2Building.renderer.sortingOrder = 1;
			}
		}
	}

	void OnMouseDown ()
	{
		if (isBuyingFood == true) {
			isBuyingFood=false;
			Destroy(clone);

		}
		if (canMoveAgain == false && canBuyFood == true && isBuyingFood==false) {
			if (gameObject.name == "Farm") {
				isBuyingFood = true;
				Vector3 tmp;
				tmp.x = gameObject.transform.position.x;
				tmp.y = gameObject.transform.position.y + (gameObject.renderer.bounds.size.y / 2) + 0.5f;
				tmp.z = gameObject.transform.position.z;
				if(clone==null) clone = Instantiate(foodControllerPrefab,tmp,Quaternion.identity) as GameObject;
			}
		}
		if (canBuild == true && canMoveAgain == true) {
			GameObject scoreController = GameObject.Find ("ScoreController") as GameObject;
			ScoreController other = scoreController.GetComponent ("ScoreController") as ScoreController;
			 bool checkGold = other.CheckGoldIsOK (200);
			if(checkGold==true)
			{
			Ground.renderer.sortingOrder = 0;
			gameObject.renderer.sortingOrder = 0;
			canMoveAgain = false;
			Ground.SetActive (false);
			canBuyFood = true;

			if (isMoving == false) {
				other.DecreaseScore (200);
			}
			else{
			isMoving = false;
				if(dragonAnimationBelong2Building!=null)
				{
				dragonAnimationBelong2Building.renderer.sortingOrder=0;
				}
			}

			return;
			}
			else{
				clone = Instantiate(noMoneyWindow,noMoneyWindow.transform.position,Quaternion.identity) as GameObject;
				Destroy (gameObject);
				Destroy (Ground);
			}

		} 
		if (canBuild == false && canMoveAgain == true) {
			if (isMoving == false) {
				Destroy (gameObject);
				Destroy (Ground);
				clone = Instantiate(cannotBuidWindow,cannotBuidWindow.transform.position,Quaternion.identity) as GameObject;


			} else {
				gameObject.transform.position = beforeMovingPosition;
				Ground.SetActive (false);
				canMoveAgain = false;
			}
		}

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (canMoveAgain == false)
			return;
		else {
			if (other.tag == "Building") {
				Ground.renderer.material.color = Color.red;
				canBuild = false;
			}
		}
	}
	
	void OnTriggerExit2D (Collider2D other)
	{
		if (canMoveAgain == false)
			return;
		else {
			if (other.tag == "Building") {
				Ground.renderer.material.color = Color.green;
				canBuild = true;
			}
		}
	}
	
	void OnTriggerStay2D (Collider2D other)
	{
		if (canMoveAgain == false)
			return;
		else {
			if (other.tag == "Building") {
				Ground.renderer.material.color = Color.red;
				canBuild = false;
			}
		}
	}
}	