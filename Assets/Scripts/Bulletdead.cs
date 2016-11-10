using UnityEngine;
using System.Collections;

public class Bulletdead : MonoBehaviour {
	public int life = 0; 

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void OnCollisionEnter(Collision boom)
	{
		//If the object that triggered this collision is tagged "Enemy"
		if (boom.gameObject.tag == "Enemy") {
			life += 1;
			if (life == 1) {
				Destroy (gameObject);

			}

		}
		//If the object that triggered this collision is tagged "Scene"
		if (boom.gameObject.tag == "Scene") {
			life += 1;
			if (life == 1) {
				Destroy (gameObject);

			}

		}
	}

}


