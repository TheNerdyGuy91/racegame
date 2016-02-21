/* Player movement */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Playermovement : MonoBehaviour {

	private Rigidbody rb; // for the movement
	private float speed; 
	private int jumpHeight;
	private bool fall;
	private Vector3 movement;
	public GameObject cameraAngle; // to move the camera at an angle
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		speed = 2.5f;
		jumpHeight = 7;
		fall = false;
	}

	void FixedUpdate () 
	{

		float x = Input.GetAxis("Horizontal"); 
		float z = Input.GetAxis("Vertical");
		// jump if user is on the ground and space is entered or climb
		movement = Camera.main.transform.TransformDirection(movement); 
		if (Input.GetKey (KeyCode.Space) && !fall) 
		{
			fall = true;
			rb.velocity = movement = new Vector3 (x * speed, jumpHeight, z * speed);
		} 
		else 
		{
			movement = new Vector3 (x, 0.0f, z);
			rb.AddForce(movement * speed);
		}

	}
	void OnCollisionEnter(Collision obj)
	{
		if (obj.gameObject.name == "bangle" || obj.gameObject.name == "bangle2") 
		{
			rb.AddForce(0, 20, 20);
		}
		if (obj.gameObject.name == "speedboost") 
		{
			rb.AddForce (50, 0, 50);
		}
	}

	// if hit the floor
	void OnCollisionStay()
	{
		fall = false;

	}
}
