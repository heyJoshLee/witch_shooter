using UnityEngine;
using System.Collections;

public class EnemyContainer : MonoBehaviour {

	public float width = 40f;
	public float height = 40f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnDrawGizmos() {
		Gizmos.DrawWireCube(transform.position, new Vector3(width, height));
	}
}
