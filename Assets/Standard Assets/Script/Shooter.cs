using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	
	public Rigidbody bullet;
	public float power = 1500f;
	public float movementSpeed = 2f;
	
	// Update is called once per frame
	void Update () {
		var h = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
		float v = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
		
		transform.Translate(h, v, 0);
		
		if(Input.GetButtonDown("Fire1"))
		{
			Rigidbody instance = Instantiate(bullet, this.transform.position, this.transform.rotation) as Rigidbody;
			Vector3 fwd = transform.TransformDirection(Vector3.forward);
			instance.AddForce(fwd * power);
		}
	}
}
