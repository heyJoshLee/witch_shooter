using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	public GameObject tree_1;
	
	// Update is called once per frame
	void Update () {
	
	if(Random.value > 0.02f) {
		Instantiate(tree_1, new Vector2(0f, 0f), Quaternion.identity); 
	}
	
	}
}
