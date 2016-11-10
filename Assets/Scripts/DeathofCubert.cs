using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
using System;

public class DeathofCubert : MonoBehaviour {

	public int life = 0; 

	public static int newScore;


	// Use this for initialization
	void Start () {
		newScore = 0;
	}

	// Update is called once per frame
	void Update () {
		

	}
	public void OnCollisionEnter(Collision boom)
	{
		//If the object that triggered this collision is tagged "Bullet"
		if (boom.gameObject.tag == "Bullet") {
			life += 1;
			if (life == 2) {
				
				Destroy (gameObject);
				newScore = 10;
			}

		}

	}

}


