using UnityEngine;
using System.Collections;

public class EnemyContainer : MonoBehaviour {

	public float width = 40f;
	public float height = 40f;
	
	public GameObject enemyPrefab;

	// transform is a special keyword that means the children of the parent. Loop through all the children of this gameobject
	void Start () {	
		SpawnEnemies();
	}
	
	void SpawnEnemies() {
		foreach(Transform child in transform) {
			// create a new enemyPrefab and the position. Make it a game object so you can do gameobject things with it.
			GameObject enemy = Instantiate(enemyPrefab, child.transform.position, Quaternion.identity) as GameObject;
			EnemyController.enemyCount += 1;
			// nest the enemyPrefab inside the child
			enemy.transform.parent = child;
		}
	}
	
	// Show the box in the scene view
	public void OnDrawGizmos() {
		Gizmos.DrawWireCube(transform.position, new Vector3(width, height));
	}
	

	
	void Update() {
		if (EnemyController.enemyCount <= 0) {
		EnemyController.speed *= 1.20f;
		EnemyController.fireRate *= 1.20f;
		EnemyController.health += 50f;
		SpawnEnemies();
		}
	}
}
