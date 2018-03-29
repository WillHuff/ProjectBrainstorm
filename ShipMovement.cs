using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {
	public float movementSpeed = 1.0f;
	public int invert = -1;
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		Vector3 direction = new Vector3 (horizontal, invert*vertical,10.0f);
		Vector3 finalDirection = new Vector3 (horizontal, invert*vertical, 50.0f);

		transform.position += direction * movementSpeed * Time.deltaTime;

		transform.rotation = Quaternion.RotateTowards (transform.rotation,Quaternion.LookRotation(direction)),Mathf.Deg2Rad*50.0f;
	}
}
