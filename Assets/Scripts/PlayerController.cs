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
	
	// Update is called once per frame
	void Update () {
		Move();
	}
	
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





















