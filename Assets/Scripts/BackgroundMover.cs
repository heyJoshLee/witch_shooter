using UnityEngine;
using System.Collections;

public class BackgroundMover : MonoBehaviour {

	public float speed = 0.5f;
	public GameObject tree_1;
	private bool spawned = false;

	// Use this for initialization
	void Start () {
		SpawnBgObject();
	}
	
	// Update is called once per frame
	void Update () {
		if (Random.value > 0.99f) {
			SpawnBgObject();
		}
	}
	
	void SpawnBgObject () {
			GameObject tree = Instantiate(tree_1, new Vector3(200f, 1f, 0f), Quaternion.identity) as GameObject;
			tree.transform.parent = gameObject.transform;		
	}
}
