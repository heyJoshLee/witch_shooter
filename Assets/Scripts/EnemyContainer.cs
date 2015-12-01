using UnityEngine;
using System.Collections;

public class EnemyContainer : MonoBehaviour {

	public float width = 40f;
	public float height = 40f;
	
	public GameObject enemyPrefab;

	// Use this for initialization
	void Start () {
	
		foreach(Transform child in transform) {
			GameObject enemy = Instantiate(enemyPrefab, child.transform.position, Quaternion.identity) as GameObject;
			enemy.transform.parent = child;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnDrawGizmos() {
		Gizmos.DrawWireCube(transform.position, new Vector3(width, height));
	}
}
