using UnityEngine;
using System.Collections;

public class BackgroundObjectMover : MonoBehaviour {

	Rigidbody2D rb2d;
	public float speed = 0.5f;
	
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		// Move object when it becomes alive
		transform.position += Vector3.left * speed;
	}
	
	void OnTriggerEnter2D (Collider2D col) {
		// Destroy object when it's off the screen
		if (col.tag == "Shredder") { Destroy(gameObject); }
	}
}
