using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ThrowController : MonoBehaviour {
	
	private BallController ballScript;
	public GameObject prefab;
<<<<<<< HEAD
	public Transform parentBone;
=======
	private GameObject parentBone;
>>>>>>> d1c4cf2d159ee7abe467698edcf1c75c9880069a
	private GameObject ball;
	public int numBalls;
	//public Animator animator;
	public Text ballsRemaining;


	// Use this for initialization
	void Start () {

		numBalls = 30;
<<<<<<< HEAD
		//animator = GetComponent<Animator> ();
		parentBone = GameObject.Find ("parentBone").transform;
		ballsRemaining = GameObject.Find("Balls Remaining").GetComponent<Text> ();
		ball = Instantiate (prefab, parentBone.position, parentBone.rotation) as GameObject;
=======
        //animator = GetComponent<Animator> ();
        parentBone = GameObject.Find("parentBone");
		ballsRemaining = GameObject.Find("BallCount").GetComponent<Text> ();
		ball = Instantiate (prefab, parentBone.transform.position, parentBone.transform.rotation) as GameObject;
>>>>>>> d1c4cf2d159ee7abe467698edcf1c75c9880069a

	}
	
	// Update is called once per frame
	void Update () {

		//ballsRemaining.text = "Balls Remaining: " + numBalls.ToString();

		if (Input.GetMouseButtonDown (0)) {
			ThrowBall ();

		}

	}

	void ThrowBall(){

		ballScript = ball.GetComponent<BallController> ();
		ballScript.Release ();

		if (numBalls > 0) {
			Invoke ("makeNewBall", 1.0f);
			numBalls--;
		}

		//Debug.Log ("Throw Ball num balls is " + numBalls);

	}

	public void makeNewBall(){
<<<<<<< HEAD
		ball = Instantiate (prefab, parentBone.position, parentBone.rotation) as GameObject;
=======
		ball = Instantiate (prefab, parentBone.transform.position, parentBone.transform.rotation) as GameObject;
>>>>>>> d1c4cf2d159ee7abe467698edcf1c75c9880069a

	}
		

	public int getNumBalls(){
		return this.numBalls;
	}



}
