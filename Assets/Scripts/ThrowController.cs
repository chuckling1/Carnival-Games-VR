using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ThrowController : MonoBehaviour {
	
	private BallController ballScript;
	public GameObject prefab;
	public Transform parentBone;
	private GameObject ball;
	public int numBalls;
	//public Animator animator;
	public Text ballsRemaining;


	// Use this for initialization
	void Start () {

		numBalls = 30;
		//animator = GetComponent<Animator> ();
		parentBone = GameObject.Find ("parentBone").transform;
		ballsRemaining = GameObject.Find("Balls Remaining").GetComponent<Text> ();
		ball = Instantiate (prefab, parentBone.position, parentBone.rotation) as GameObject;

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
		ball = Instantiate (prefab, parentBone.position, parentBone.rotation) as GameObject;

	}
		

	public int getNumBalls(){
		return this.numBalls;
	}



}
