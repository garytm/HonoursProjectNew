using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    public float speed = 0.1f;
    public Rigidbody rigidBody;
	
	void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3 (moveVertical, 0.0f, moveHorizontal);

        rigidBody.AddForce(movement * speed);
	}
}
