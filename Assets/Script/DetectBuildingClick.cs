using UnityEngine;
using System.Collections;

public class DetectBuildingClick : MonoBehaviour
{
	private GameObject root;
	// Use this for initialization
	void Start ()
	{
	
	}

	void OnMouseDown ()
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

		root = GameObject.Find ("Hide_Building");
		Transform[] ts = root.GetComponentsInChildren<Transform> ();
		foreach (Transform t in ts) {
			if (t.tag == "GUI_Hide") {
				t.guiTexture.enabled = true;
			}
		}

	}

	// Update is called once per frame
	void Update ()
	{
	
	}
}
