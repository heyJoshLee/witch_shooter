using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	
	public float health = 150f;
	
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "PlayerAttack") {
			Debug.Log("Hit enemy");
			Magic magic = col.gameObject.GetComponent<Magic>();
			health -= magic.ReturnDamage();
			
			if (health <= 0f) {
				Destroy(gameObject);
			}
		}
	}
}
