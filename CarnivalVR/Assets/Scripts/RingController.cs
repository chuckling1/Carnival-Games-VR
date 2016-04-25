using UnityEngine;
using System.Collections;

public class RingController : MonoBehaviour {

	private Rigidbody rb;
	private float randomPower;
	//public GameObject mainCamera;
	//public GameObject parentBone;
	//public Animator animator;
	//public Animation animation;
	public bool animation_bool;



	//private float rotation;
	//private bool right = true;

	//public float speed;



	// Use this for initialization
	void Start () 
	{
		Random.seed = 42;
		rb = GetComponent<Rigidbody> ();
		//animator = GetComponent<Animator> ();
		//animation = GetComponent<Animation> ();
		//transform.parent = parentBone.transform;
		rb.useGravity = false;
	}

	/*
	void Update()
	{
		if(animation_bool == true)
		{
			animation.Play("Throw Ball");
		}
		if(Input.GetButtonDown("Jump"))
		{
			animation_bool = true;
		}
			
	}



	// FixedUpdate is called once per frame if an event is detected
		void FixedUpdate()
		{

			
			if(Input.GetButtonDown("Jump")){

					//randomPower = Random.value * 10000;
					rb.useGravity = true;
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
					rb.AddForce(mainCamera.transform.forward * 10000);

					
					//rb.AddForce(movement * randomPower);
					//rb.transform.Rotate(rotation * Time.deltaTime, Space.Self);
			}else{}
		}

	*/

}

