using UnityEngine;
using System.Collections;

public class FoodChoiceController : MonoBehaviour {
	public GameObject root;
	public GameObject waitingPrefab;
	//public GameObject scoreController;

	private  GameObject scoreController=null;
	private ScoreController scoreControllerScript;
	private Vector3 orgizinalPosition;
	private GameObject clone;


	void IncreaseFood1()
	{
		scoreControllerScript.IncreaseFood(5);
		scoreControllerScript.DecreaseScore(50);
		Destroy (clone);
		Destroy (root);
	}
	void IncreaseFood2()
	{
		scoreControllerScript.IncreaseFood(300);
		scoreControllerScript.DecreaseScore(250);
		Destroy (clone);
		Destroy (root);
		}
	void IncreaseFood3()
	{
		scoreControllerScript.IncreaseFood(1500);
		scoreControllerScript.DecreaseScore(5000);
		Destroy (clone);
		Destroy (root);
	}
	void OnMouseDown() {
		if (Input.GetMouseButtonDown (0)) {
			scoreControllerScript=scoreController.GetComponent("ScoreController") as ScoreController;
			clone = Instantiate(waitingPrefab,root.transform.position,Quaternion.identity) as GameObject;

			if(gameObject.name=="1")
			{
				root.SetActive(false);
				Invoke("IncreaseFood1",1f);
			}
			if(gameObject.name=="2")
			{
				root.SetActive(false);
				Invoke("IncreaseFood2",60f);

			}
			if(gameObject.name=="3")
			{
				root.SetActive(false);
				Invoke("IncreaseFood3",300f);
			}




		}
	}
	// Use this for initialization

	void Start ()
	{
		scoreController = GameObject.Find ("ScoreController")as GameObject;
	}
	// Update is called once per frame
	void Update () {

	}

}
