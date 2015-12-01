using UnityEngine;
using System.Collections;

public class Magic : MonoBehaviour {

	static public float damage = 100;

	// If the magic hits the player or the Shredder then kill the magic. Could do this differently
		// with collision layers
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Enemy" || col.tag == "Shredder"){
			Destroy(gameObject);
		}
	}
	
	// This is used to deal damage
	public float ReturnDamage() {
		return damage;
	}
	
}
