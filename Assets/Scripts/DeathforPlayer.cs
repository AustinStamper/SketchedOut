using UnityEngine;
using System.Collections;

public class DeathforPlayer : MonoBehaviour {
	public int playerLife = 0;
	public Collision boom;
	public static int damage = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void OnCollisionEnter(Collision boom)
	{
		//If the object that triggered this collision is tagged "Bullet"
		if (boom.gameObject.tag == "Enemy") {
			damage = 10;
			playerLife += 1;
			if (playerLife == 10) {
				Time.timeScale = 0f;
				 
			}

		}
		if (boom.gameObject.tag == "Enemy2") {
			damage = 20;
			playerLife += 2;
			if (playerLife == 10) {
				Time.timeScale = 0f;

			}

		}
}
}
