using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager: MonoBehaviour {

	public void OpenScene(int index) {
		SceneManager.LoadScene( index );
	}

	private void Update() {
		if(Input.GetKeyDown( KeyCode.Escape ) && SceneManager.GetActiveScene().buildIndex != 0) {
			SceneManager.LoadScene( 0 );
		}

		if(Input.GetKeyDown( KeyCode.R )) {
			SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
		}
	}
}
