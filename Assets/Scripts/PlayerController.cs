using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	float ymin = 0f;
	float ymax = 0f;
	float xmin = 0f;
	float xmax = 0f;
	
	Rigidbody2D rb2d;
	public float speed = 10f;
	public float hPadding = 0.5f;
	public float leftPadding = 0.5f;
	public float rightPadding = 0.5f;
	public GameObject attack;
	public float firingRate = 0.2f;
	static public float health = 150; 

	void Start () {

		// Shows distance between object and camera	
		float distance = transform.position.z - Camera.main.transform.position.z;
		// Finds the topmost and bottommost point of the camera to calculate clamps later
		Vector3 bottomleft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
		Vector3 topright = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, distance));
		// Keeps the whole character sprite inside the play area
		ymin = bottomleft.y + hPadding;
		ymax = topright.y - hPadding;
		
		xmin = bottomleft.x + leftPadding;
		xmax = topright.x - rightPadding;
		
		rb2d = GetComponent<Rigidbody2D>();
	
		
	
	}
	
	void Update () {
		Move();
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			InvokeRepeating("Shoot", 0.000001f, firingRate);
		}
		if (Input.GetKeyUp(KeyCode.Space)) {
			CancelInvoke("Shoot");
		}
	}
	
	
	void Shoot() {
		if (Input.GetKey(KeyCode.Space)) {
				GameObject fire = Instantiate(attack, new Vector3(transform.position.x + 13f, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 90f)) as GameObject;
				fire.GetComponent<Rigidbody2D>().velocity = new Vector3(50f, 0f, 0f); 
		}
	}
	// TODO: limit fire rate

	
	void Move () {
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.position += Vector3.down * speed * Time.deltaTime;
		} else if (Input.GetKey(KeyCode.UpArrow)) {
			transform.position += Vector3.up * speed * Time.deltaTime;
		} else if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.position += Vector3.left * speed * Time.deltaTime;
		}	else if (Input.GetKey(KeyCode.RightArrow)) {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		
		float newx = Mathf.Clamp(transform.position.x, xmin, xmax);
		
		float newy = Mathf.Clamp(transform.position.y, ymin, ymax);
		
		transform.position = new Vector2(newx, newy);
	}
	
	
}





















