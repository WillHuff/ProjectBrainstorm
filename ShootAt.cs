using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAt : MonoBehaviour {
	public Rigidbody bullet;
	public float velocity = 5.0f;

	// Use this for initialization
	void Start () {
		StartCoroutine (Fire ());
	}
	
	IEnumerator Fire()
	{
		Rigidbody newBullet = Instantiate(bullet,transform.position,transform.rotation) as Rigidbody;
		newBullet.AddForce(transform.forward*velocity,ForceMode.VelocityChange);
		yield return new WaitForSeconds (1);
		StartCoroutine (Fire ());
	}
}
