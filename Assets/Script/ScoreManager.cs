using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager: MonoBehaviour {

	public Text textScore;
	public int score {
		get;
		private set;
	}
	public static ScoreManager instance {
		get;
		private set;
	}

	void Awake() {
		instance = this;
	}

	public void addScore() {
		score += 1;
	}

	void Update() {
		textScore.text = score.ToString();
	}

}
