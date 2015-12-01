using UnityEngine;
using System.Collections;

public class Magic : MonoBehaviour {

	static public float damage = 100;

	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Enemy"){
			Destroy(gameObject);
		} else if (col.tag == "Shredder") {
			Destroy(gameObject);
		}
	}
	
	
	public float ReturnDamage() {
		return damage;
	}
	
}
