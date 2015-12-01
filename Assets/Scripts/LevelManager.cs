using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	static public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void LoadLevel(string name) {
		Application.LoadLevel(name);
	}
}
