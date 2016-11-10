#pragma strict
var prefabBullet:Rigidbody;
var shootForce:float;
var shootPosition:Transform;
var player:Transform;
var totalAmmo:int;

totalAmmo = 5;

function Update()
{
	if(Input.GetButtonDown("Fire1") && totalAmmo!= 0)
	{
	var instanceBullet = Instantiate(prefabBullet, transform.position, shootPosition.rotation);

	instanceBullet.GetComponent.<Rigidbody>().AddForce(shootPosition.forward * shootForce);

	totalAmmo--;

	}
}