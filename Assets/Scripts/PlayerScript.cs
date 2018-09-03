using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float speed;

	void Start () {
		
	}
	
	void Update () {
		float jump = Input.GetAxis("Jump");
		float horizontal = Input.GetAxis("Horizontal");
		Rigidbody2D rb = GetComponent<Rigidbody2D>();

		rb.AddForce((transform.right * speed) * horizontal);

	}
}
