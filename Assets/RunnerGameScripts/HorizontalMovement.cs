using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
	public float swipeSpeed;
	public float swipeSensitivity;
	public float xPosition;
	public Vector3 newPosition;

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			xPosition = Input.mousePosition.x;
		}
		else if (Input.GetMouseButton(0))
		{
			float currentxPosition = Input.mousePosition.x;
			float difference = currentxPosition - xPosition;
			newPosition.x = difference * swipeSensitivity * Time.deltaTime + transform.position.x;
			newPosition.y = transform.position.y;
			newPosition.z = transform.position.z;

			newPosition.x = Mathf.Clamp(newPosition.x, -3.4f, 3.4f); 

			transform.position = newPosition;
		}
	}
}
