using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	
	public float health = 150f;
	public float fireRate = 0.001f;
	public GameObject enemyAttack;
	public float speed = 1.0f;
	
	// Check to see if the Enemy gets hit by a PlayerAttack
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "PlayerAttack") {
			// Need to make a Magic object so we can call the return damage method. Or we could just make the return damage method
			   // a static method
			Magic magic = col.gameObject.GetComponent<Magic>();
			health -= magic.ReturnDamage();
			
			// if this.health is lower than 0 then destroy this object
			if (health <= 0f) {
				Destroy(gameObject);
			}
		}
	}
	
	// Will the enemy fire? Time.deltaTime smooths everything out. USE IT
	void Update() {
		if(Random.value <= fireRate * Time.deltaTime){
			EnemyFire();
		}	
	}
	
	// Create a enemyAttack object
	void EnemyFire() {
		// Turn into game object so you can do game object things with it.
		GameObject enemyShot = Instantiate(enemyAttack, transform.position, Quaternion.identity) as GameObject;
		// Need to get a RigidBody2D so you can add velocity to it. Need velocity because it is speed and direciton
		enemyShot.GetComponent<Rigidbody2D>().velocity = Vector3.left * speed;
	}
	
}
