using UnityEngine;
using System.Collections;

public class GuiController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void CloseAll()
	{
		GameObject [] OtherRoot2Hide;
		OtherRoot2Hide = GameObject.FindGameObjectsWithTag ("GUi_HideIcon");
		foreach (GameObject go in OtherRoot2Hide) {
			Transform[] tmp = go.GetComponentsInChildren<Transform> ();
			foreach (Transform t in tmp) {
				if (t.tag == "GUI_Hide") {
					t.guiTexture.enabled = false;
				}
			}
		}
	}
}
