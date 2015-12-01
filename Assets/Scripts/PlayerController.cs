using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	float ymin = 0;
	float ymax = 0;
	Rigidbody2D rb2d;
	public float speed = 10;
	public float padding = 0.5f;

	void Start () {

	// Shows distance between object and camera	
	float distance = transform.position.z - Camera.main.transform.position.z;
	//
	Vector3 topmost = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distance));
	Vector3 bottommost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
	ymax = topmost.y - padding;
	ymin = bottommost.y + padding;
	rb2d = GetComponent<Rigidbody2D>();
	
	Debug.Log(ymin);
	Debug.Log(ymax);
		
	
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
		}
		
		float newy = Mathf.Clamp(transform.position.y, ymin, ymax);
		
		transform.position = new Vector2(transform.position.x, newy);
	}
	
}





















