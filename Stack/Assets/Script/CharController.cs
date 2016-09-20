using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

	float speed = 8.0f;
	float jumpSpeed = 14.0f;
	float gravity = 20.0f;

	bool isJumping;

	CharacterController theController;

	Vector3 moveDirection = Vector3.zero;
	Vector3 jumpDirection = Vector3.zero;

	// Use this for initialization
	void Start () {
		theController = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		GetInputs ();
	}

	void GetInputs ()
	{
		if (isJumping)
		{		
			if (Input.GetButtonDown ("Jump"))
			{
				moveDirection = new Vector3 (Input.GetAxis ("Horizontal") * speed, moveDirection.y * -speed, Input.GetAxis ("Vertical") * speed);
			}
			else
				moveDirection = new Vector3 (Input.GetAxis ("Horizontal") * speed, moveDirection.y, Input.GetAxis ("Vertical") * speed);
		}

		if (theController.isGrounded)
		{
			isJumping = false;
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;

			if (Input.GetButtonDown ("Jump"))
			{
				moveDirection.y = jumpSpeed;
				isJumping = true;
			}
		}

		moveDirection.y -= gravity * Time.deltaTime;

		theController.Move(moveDirection * Time.deltaTime);
	}
}
