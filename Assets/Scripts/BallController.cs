using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	private Rigidbody rb;
	private GameObject mainCamera;
<<<<<<< HEAD
	private GameObject parentBone;

=======
    public GameObject reticle;
>>>>>>> d1c4cf2d159ee7abe467698edcf1c75c9880069a




	//private float rotation;
	//private bool right = true;

	//public float speed;



	// Use this for initialization
	void Start () 
	{
		


	}


	public void Release()
	{
		rb = GetComponent<Rigidbody> ();

<<<<<<< HEAD
		parentBone = GameObject.Find ("parentBone");
		mainCamera = GameObject.Find ("MainCamera");
		transform.parent = parentBone.transform;
=======
        //parentBone = GameObject.Find("parentBone");
        reticle = GameObject.Find("Reticle");
        mainCamera = GameObject.Find("CenterEyeAnchor");
        transform.parent = reticle.transform;
>>>>>>> d1c4cf2d159ee7abe467698edcf1c75c9880069a
		rb.useGravity = false;

		transform.parent = null;
		rb.useGravity = true;

<<<<<<< HEAD
		transform.rotation = mainCamera.transform.rotation;
		rb.AddForce(transform.forward * 16000);
		rb.AddForce (new Vector3 (-1.0f, 1.0f, 0.0f) * 1000);
=======

  

		transform.rotation = mainCamera.transform.rotation;

        /*
        Ray tempRay = Camera.main.ScreenPointToRay(reticle.transform.position);
        RaycastHit hit;

        Physics.Raycast(tempRay, out hit);
        rb.MovePosition(hit.point);
        rb.AddForce(tempRay.direction * 100);
        */

        Vector3 direction = (reticle.transform.position - transform.position).normalized;


        rb.AddForce(direction * 20000);
		//rb.AddRelativeForce (new Vector3 (-1.0f, 1.0f, 0.0f) * 1000);
>>>>>>> d1c4cf2d159ee7abe467698edcf1c75c9880069a


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

