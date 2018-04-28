using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {
	public int initialGold=10000;
	public int initialFood=0;
	public int initialDragon=0;
	public GUIText goldCount;
	public GUIText foodCount;
	public GUIText dragonCount;

	// Use this for initialization
	void Start () {
		goldCount.text = ""+initialGold;
		foodCount.text= ""+initialFood;
		dragonCount.text =  ""+initialDragon;
	
	}

	
	// Update is called once per frame
	void Update () {
		goldCount.text = ""+initialGold;
		foodCount.text= ""+initialFood;
		dragonCount.text =  ""+initialDragon;
	
	}
	public void IncreaseScore(int score)
	{
		initialGold = initialGold + score;
	}
	public void DecreaseScore(int score)
	{

		initialGold = initialGold - score;
	}
	public void IncreaseFood( int food)
	{
		initialFood = initialFood + food;
	}
	public void DecreaseFood( int food)
	{
		initialFood = initialFood - food;
	}
	public void IncreaseDragon( int dragon)
	{
		initialDragon = initialDragon + dragon;
	}
	public bool CheckGoldIsOK( int gold)
	{
		int tmp = initialGold - gold;
		return(tmp >= 0);
	}

}
