using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	private Rigidbody rb;
	private GameObject mainCamera;
	private GameObject parentBone;





	//private float rotation;
	//private bool right = true;

	//public float speed;



	// Use this for initialization
	void Start () 
	{
		Random.seed = 42;
		rb = GetComponent<Rigidbody> ();

		parentBone = GameObject.Find ("Palm_R");
		mainCamera = GameObject.Find ("Main Camera");
		transform.parent = parentBone.transform;
		rb.useGravity = false;

	}


	public void Release()
	{
		transform.parent = null;
		rb.useGravity = true;

		transform.rotation = mainCamera.transform.rotation;
		rb.AddForce(transform.forward * 46000);
		rb.AddForce (new Vector3 (-1.2f, 0.3f, 0.0f) * 1000);


	}


	// FixedUpdate is called once per frame if an event is detected
		void FixedUpdate()
		{
			
			/*
			if(Input.GetButtonDown("Jump")){

			}else if(Input.GetButtonUp("Jump")){
			
					//Vector3 movement = new Vector3(-0.1f, 1.0f, 5.0f);
					//Vector3 rot = new Vector3 (-5.0f, -0.0f, 0.0f);
					
					//cheat.position = transform.position;
					//cheat.rotation = Camera.main.transform.rotation;
					
					//Vector3 lookAt = cheat.position + cheat.forward;
					//lookAt.y = transform.position.y;
					//cheat.transform.LookAt(lookAt);

					//rb.AddTorque(cheat.TransformDirection(rot) * 500 * 100.5f);
					//rb.AddForce(cheat.TransformDirection(dir) * 5000 * 0.5f);
					//rb.AddForce(Physics.gravity * rb.mass);
					
					
					//rb.AddForce(movement * randomPower);
					//rb.transform.Rotate(rotation * Time.deltaTime, Space.Self);
			}else{}

*/

		}



}

