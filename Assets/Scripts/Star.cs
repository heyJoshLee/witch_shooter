using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {

	public float damage = 100;
	public GameObject player;
		
	// Find player so it can be destroyed
	void Start() {
		// Need to find the player so the player can be killed
		player = GameObject.Find("Player");
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Player") {
			PlayerController.health -= damage;
			Destroy(gameObject);
		}
		// Destroy star if it goes off the screen
		if (col.tag == "Shredder") {
			Destroy(gameObject);
		}
		// Remove player if Player's health depletes
		if (PlayerController.health <= 0) {
			Destroy(player);
			LevelManager.LoadNextLevel();
		}
	}
}
