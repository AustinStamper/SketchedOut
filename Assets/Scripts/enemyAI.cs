using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {
	public Transform Player;
	public int life = 0;


	void Start() {
	
	}


	void Update () {


		if(Vector3.Distance(Player.position, this.transform.position) < 1000)
		{
			Vector3 direction = Player.position - this.transform.position;
			direction.y = 0;

			this.transform.rotation = Quaternion.Slerp(this.transform.rotation,Quaternion.LookRotation(direction), 0.1f);
			
				if(direction.magnitude > 0)
				{
				this.transform.Translate(0,0,0.04f);
				}
		}
	}
}