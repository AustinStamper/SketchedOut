using UnityEngine;
using System.Collections;

public class DeathofChez : MonoBehaviour {

	public int life = 0; 
	public static int newScore;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void OnCollisionEnter(Collision boom)
	{
		//If the object that triggered this collision is tagged "Bullet"
		if (boom.gameObject.tag == "Bullet") {
			life += 1;
			if (life == 4) {
				Destroy (gameObject);
				newScore = 20;
			}

		}

	}

}




