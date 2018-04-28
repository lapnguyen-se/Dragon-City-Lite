using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MoveCamera : MonoBehaviour 
{

	public float panSpeed = 450.0f;
	public float zoomSpeed = 360.0f;

	public float panDrag = 7f;			// RigidBody Drag when panning camera

	private Vector3 mouseOrigin;
	private Vector3 move = new Vector3(1,1,1);

	private bool isPanning;	
	private bool isZooming;	

				
	void Awake()
	{
		gameObject.AddComponent<Rigidbody>();
		rigidbody.useGravity = false;

	}
	void Start()
	{

	}
	void Update () 
	{
		if(Input.GetMouseButtonDown(2))
		{
			// Get mouse origin
			mouseOrigin = Input.mousePosition;
			isPanning = true;
		}
		if(Input.GetMouseButtonDown(1))
		{
			// Get mouse origin
			mouseOrigin = Input.mousePosition;
			isZooming = true;

		}
		if (!Input.GetMouseButton(2))  isPanning = false;
		if (!Input.GetMouseButton(1))  isZooming = false;


		if(transform.position.x>= 21)
		{
			Vector3 newVal = new Vector3 (21,transform.position.y,transform.position.z);
			transform.position=newVal;
		}
		if(transform.position.x<= -22)
		{
			Vector3 newVal = new Vector3 (-22,transform.position.y,transform.position.z);
			transform.position=newVal;
		}
		if(transform.position.y>= 26)
		{
			Vector3 newVal = new Vector3 (transform.position.x,26,transform.position.z);
			transform.position=newVal;
		}
		if(transform.position.y<= -24)
		{
			Vector3 newVal = new Vector3 (transform.position.x,-24,transform.position.z);
			transform.position=newVal;
		}


	}

	void FixedUpdate()
	{

		// Move (pan) the camera on it's XY plane
		if (isPanning)
		{

			// Get mouse displacement vector from original to current position
	    		Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);
	    		move = new Vector3(pos.x * panSpeed, pos.y * panSpeed, 0);


			// Set Drag
			rigidbody.drag = panDrag;


			// Pan
			rigidbody.AddForce(move, ForceMode.Acceleration);

		}
		if (isZooming)
		{

			// Get mouse displacement vector from original to current position
			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);
			float k = pos.x - pos.y;
			float tmp = Mathf.Sqrt(Mathf.Pow(pos.x,2)+Mathf.Pow(pos.y,2))/5;
			float Size=0;
			//Camera.main.orthographic = true;
			if(k>0)
			{
				Size = Camera.main.orthographicSize + tmp;

			}
			if(k<0)
			{
				Size = Camera.main.orthographicSize - tmp;

			}
			if(k==0) return;
			if(Size > 2  && Size < 5) Camera.main.orthographicSize = Size;

		}
	}

}
