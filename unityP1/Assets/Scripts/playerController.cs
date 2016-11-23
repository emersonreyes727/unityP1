﻿using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () // physics code - called before performing any physics
	// calculations
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
    	if (other.gameObject.CompareTag("Pick Up"))
    	{
    		other.gameObject.SetActive(false);
    	}	 
    }
}

