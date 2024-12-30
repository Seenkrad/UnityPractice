using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
	private Camera mainCamera;
	private Vector3 previousMousePosition;
	private bool isDrag = false;
	private float rotSpeed = 0.2f;
	// // Start is called before the first frame update
	void Start()
	{
		mainCamera = Camera.main;
	}

	void OnMouseDown()
	{
		if (CompareTag("Object"))
		{isDrag = true;
		previousMousePosition = Input.mousePosition;}
	}

	void OnMouseUp() {isDrag = false;}

	void OnMouseDrag()
	{
		if (isDrag)
		{
			Vector3 delta = Input.mousePosition - previousMousePosition;
			transform.Rotate(Vector3.up, delta.x * rotSpeed, Space.World);
			transform.Rotate(Vector3.right, -delta.y * rotSpeed, Space.World);
			previousMousePosition = Input.mousePosition;
		}
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
