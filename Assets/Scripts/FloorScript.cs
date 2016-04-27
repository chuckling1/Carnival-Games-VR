using UnityEngine;
using System.Collections;

public class FloorScript : MonoBehaviour {
	private static int numBottlesTouching;
	private MilkJugScript milkJug;

	// Use this for initialization
	void Start () {
		numBottlesTouching = 0;
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision collision) 
	{
		//milkJug = collision.GetComponent<MilkJugScript> ();
		if (collision.collider.tag == "MilkJug") {
			milkJug = collision.collider.GetComponent<MilkJugScript> ();


			Debug.Log ("Jug collided numBottlesTouching is " + numBottlesTouching + " has collided is " + milkJug.hasCollided);

			if (milkJug.hasCollided == false) {

				numBottlesTouching++;

				milkJug.hasCollided = true;

			}
		}

		if(numBottlesTouching == 6)
		{
			Debug.Log("Winner");
		}

	}
}
