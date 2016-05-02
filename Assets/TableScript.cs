using UnityEngine;
using System.Collections;

public class TableScript : MonoBehaviour {

	private Rigidbody rigidBody;
	private long index;
	private int numBalls;
	private GameObject arms;
	 

	// Use this for initialization
	void Start () {
		index = 0;
		rigidBody = GetComponent<Rigidbody> ();

		arms = GameObject.Find("Arms05");
		ThrowController throwController = arms.GetComponent<ThrowController> ();


		numBalls = throwController.getNumBalls ();
		Debug.Log ("numBalls is " + numBalls);
	}
	
	// Update is called once per frame
	void OnCollisionStay(){
		
	}


	void Update(){
		if (numBalls == 0) {
			//Debug.Log ("Winner");
		}
	}


}


