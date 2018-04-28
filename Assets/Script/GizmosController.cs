using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class GizmosController : MonoBehaviour
{
	private Vector3 screenPoint;
	private Vector3 offset;
	private Vector3 originPosition;
	private bool canBuild = true ;
	private bool canMoveAgain = true;

	void Start()
	{
		originPosition = gameObject.transform.position;

	}
	
	void OnMouseDown ()
	{
		//phai chuyen tu world sang screen
		screenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position);
		//vì vị trí của trỏ chuột là vị trí trên màn hình nên muốn tìm khoảng cách sau khi dịch chuyen phải chuyển sang hệ tọa độ world
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}
	
	void OnMouseDrag ()
	{

		if(canMoveAgain==true)
		{
		Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
		transform.position = curPosition;

		
		}

	}

	void OnTriggerEnter2D ()
	{
		renderer.material.color = Color.red;
		canBuild = false;
	}

	void OnTriggerExit2D ()
	{
		renderer.material.color = Color.white;
		canBuild = true;
	}

	void OnTriggerStay2D ()
	{
		renderer.material.color = Color.red;
		canBuild = false;
	}

	void OnMouseUp ()
	{
		if(canBuild==true)
		{
			canMoveAgain=false;
		}
		if(canBuild==false)	
		{
				
			this.gameObject.transform.position = this.originPosition;
		}

	}
	
}