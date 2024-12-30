using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
	public float moveSpeed = 10f, rotationX = 0f, rotationY = 0f,sen = 1000f;
	// // Start is called before the first frame update
	// void Start()
	// {

	// }

	// Update is called once per frame
	void Update()
	{
		float mouseMoveX = Input.GetAxis("Mouse X");
		float mouseMoveY = Input.GetAxis("Mouse Y");
		float h = Input.GetAxis("Horizontal"), v = Input.GetAxis("Vertical");
		Vector3 moveDir = new Vector3(h, 0, v);
		rotationX += mouseMoveY * Time.deltaTime * sen;
		rotationY += mouseMoveX * Time.deltaTime * sen;
		if (rotationX > 35f) rotationX = 35f;
		if (rotationY < -30f) rotationY = -30f;
		transform.eulerAngles = new Vector3(-rotationX, rotationY, 0);
	}
}
