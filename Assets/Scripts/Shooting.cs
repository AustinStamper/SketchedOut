using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public Rigidbody bullet;
	public Transform bulletspawn;

	public int speed;

	public float firingrate;
	public float delay;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && Time.time > delay) {

			Rigidbody bulletInstance;
			bulletInstance = Instantiate(bullet, bulletspawn.position, bulletspawn.rotation) as Rigidbody;
			bulletInstance.AddForce (bulletspawn.forward * speed);
			delay = Time.time + firingrate;

		}
	}
}
