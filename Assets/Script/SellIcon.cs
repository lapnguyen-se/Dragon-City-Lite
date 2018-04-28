using UnityEngine;
using System.Collections;

public class SellIcon : MonoBehaviour {
	private GameObject tmpGameObject=null;
	private Vector3 position;
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
		if (tmpGameObject != null) {
			if (tmpGameObject.name == "Farm" || tmpGameObject.name == "Flower" || tmpGameObject.name == "FlowerBox"
				|| tmpGameObject.name == "SwimmingHole") {
				GameObject scoreController = GameObject.Find ("ScoreController") as GameObject;
				ScoreController other = scoreController.GetComponent ("ScoreController") as ScoreController;
				other.IncreaseScore (100);
			} else {
				if (tmpGameObject.name == "SeaHa" || tmpGameObject.name == "NatureHa"
					|| tmpGameObject.name == "ElectricHa") {
					GameObject scoreController = GameObject.Find ("ScoreController") as GameObject;
					ScoreController other = scoreController.GetComponent ("ScoreController") as ScoreController;
					MoveBuilding tmpMoveBuilding = tmpGameObject.GetComponent ("MoveBuilding") as MoveBuilding; 
					if (tmpMoveBuilding.dragonAnimationBelong2Building != null) {
						print("AAA");
						print(tmpMoveBuilding.dragonAnimationBelong2Building.name);
						if(tmpMoveBuilding.dragonAnimationBelong2Building.name=="DarkAnimation(Clone)")
						{
						other.IncreaseScore (100+750);
						}
						else if(tmpMoveBuilding.dragonAnimationBelong2Building.name=="RedAnimation(Clone)")
						{
							other.IncreaseScore (100+900);
						}
						else if(tmpMoveBuilding.dragonAnimationBelong2Building.name=="YelllowAnimation(Clone)")
						{
							other.IncreaseScore (100+1500);
						}
						Destroy (tmpMoveBuilding.dragonAnimationBelong2Building);
					} else {
						other.IncreaseScore (100);
					}

				}
			}
			if (tmpGameObject != null) {
				Destroy (tmpGameObject);
			}

		}
		if (gameObject != null)
			Destroy (gameObject);
	}
}
