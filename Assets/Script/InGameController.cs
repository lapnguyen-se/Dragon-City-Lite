using UnityEngine;
using System.Collections;

public class InGameController : MonoBehaviour {
	private GameObject RootHideBuilding;
	private GameObject RootHideDecorations;
	private GameObject RootHideHabitat;
	private GameObject RootHideEgg;
	// Use this for initialization
	void Start () {
		RootHideBuilding=GameObject.Find("Hide_Building");
		Transform[] ts = RootHideBuilding.GetComponentsInChildren<Transform>();
		foreach (Transform t in ts) 
			if(t.tag == "GUI_Hide")
		{
			t.guiTexture.enabled=false;
		}

		RootHideDecorations=GameObject.Find("Hide_Decorations");
		ts = RootHideDecorations.GetComponentsInChildren<Transform>();
		foreach (Transform t in ts) 
			if(t.tag == "GUI_Hide")
		{
			t.guiTexture.enabled=false;
		}

		RootHideHabitat=GameObject.Find("Hide_Habitat");
		ts = RootHideHabitat.GetComponentsInChildren<Transform>();
		foreach (Transform t in ts) 
			if(t.tag == "GUI_Hide")
		{
			t.guiTexture.enabled=false;
		}

		RootHideEgg=GameObject.Find("Hide_Egg");
		ts = RootHideEgg.GetComponentsInChildren<Transform>();
		foreach (Transform t in ts) 
			if(t.tag == "GUI_Hide")
		{
			t.guiTexture.enabled=false;
		}

	
	}
	void OnGUI () {
	

	
//		Rect guiBuildingPosition = new Rect(0,500,100,100);
//		GUI.DrawTexture(guiBuildingPosition, guiBuilding);
//		if(Input.GetMouseButton(0))
//		{
//			if (guiBuildingPosition.Contains(Event.current.mousePosition)) Debug.Log("AAA");
//		}
//		Rect guiQuestPosition = new Rect(100,500,100,100);
//		GUI.DrawTexture(guiQuestPosition, guiQuest);
//		if(Input.GetMouseButton(0))
//		{
//			if (guiQuestPosition.Contains(Event.current.mousePosition)) Debug.Log("AAA");
//		}
//		Rect guiMarketPosition = new Rect(200,500,100,100);
//		GUI.DrawTexture(guiMarketPosition, guiMarket);
//		if(Input.GetMouseButton(0))
//		{
//			if (guiMarketPosition.Contains(Event.current.mousePosition)) Debug.Log("AAA");
//		}
//		Rect guiInvenPosition = new Rect(300,500,100,100);
//		GUI.DrawTexture(guiInvenPosition, guiInven);
//		if(Input.GetMouseButton(0))
//		{
//			if (guiInvenPosition.Contains(Event.current.mousePosition)) Debug.Log("AAA");
//		}
//
//		Rect guiGoldPosition = new Rect(200,10,160,60);
//		GUI.DrawTexture(guiGoldPosition, guiGold);
//		if(Input.GetMouseButton(0))
//		{
//			if (guiGoldPosition.Contains(Event.current.mousePosition)) Debug.Log("AAA");
//		}
//
//		Rect guiMeatPosition = new Rect(380,8,160,60);
//		GUI.DrawTexture(guiMeatPosition, guiMeat);
//		if(Input.GetMouseButton(0))
//		{
//			if (guiMeatPosition.Contains(Event.current.mousePosition)) Debug.Log("AAA");
//		}
//
//		Rect guiHumanPosition = new Rect(560,14,160,55);
//		GUI.DrawTexture(guiHumanPosition, guiHuman);
//		if(Input.GetMouseButton(0))
//		{
//			if (guiHumanPosition.Contains(Event.current.mousePosition)) Debug.Log("AAA");
//		}
//
//		Rect guiMiniMapPosition = new Rect(865,400,200,190);
//		GUI.DrawTexture(guiMiniMapPosition, guiMiniMap);
//		if(Input.GetMouseButton(0))
//		{
//			if (guiMiniMapPosition.Contains(Event.current.mousePosition)) Debug.Log("AAA");
//		}
///bbbbssds

		
	} 
	// Update is called once per frame
	void Update () {
	
	}
}
