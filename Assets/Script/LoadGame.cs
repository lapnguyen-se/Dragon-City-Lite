using UnityEngine;
using System.Collections;

public class LoadGame : MonoBehaviour {
	public GameObject playWordPrefab=null;
	private GameObject clone=null;
	// Use this for initialization
	void Start () {
		
	}
	void OnMouseEnter() {
		renderer.material.color = Color.yellow;
		SoundEffectsHelper.Instance.MouseEnterSound ();
		Vector3 tmp;
		tmp.x = gameObject.transform.position.x;
		tmp.y = gameObject.transform.position.y;
		tmp.z = playWordPrefab.transform.position.z;
		clone = Instantiate(playWordPrefab,tmp,Quaternion.identity) as GameObject;
		
	}
	void OnMouseExit()
	{
		renderer.material.color = Color.white;
		Destroy (clone);
	}
	void OnMouseDown()
	{
		
		SoundEffectsHelper.Instance.MouseClickSound ();
		Application.LoadLevel ("scene_InGame");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
