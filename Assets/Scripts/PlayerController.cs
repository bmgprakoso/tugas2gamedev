using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;             //Floating point variable to store the player's movement speed.
	private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

	// Use this for initialization
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();

	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void FixedUpdate()
	{
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");
		//Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		//rb2d.AddForce (movement * speed);


		/* Basic input logic. GetKey is grabbing

         * the keycodes we created in our Game Manager

         */

		if (Input.GetKey (GameManager.GM.up)) {
			transform.position += Vector3.up / 2;
		}
		if (Input.GetKey (GameManager.GM.down)) {
			transform.position += Vector3.down / 2;
		}
		if (Input.GetKey (GameManager.GM.left)) {
			transform.position += Vector3.left / 2;
		}
		if (Input.GetKey (GameManager.GM.right)) {
			transform.position += Vector3.right / 2;
		}

			
	}
}
