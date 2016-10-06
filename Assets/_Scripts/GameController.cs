using UnityEngine;
using UnityEngine.UI; //needed for UI
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;//needed for scene changes


public class GameController : MonoBehaviour {
    // PRIVATE INSTANCE VARIBLES++++++++++++++++++++++++

	private int _scoreValue;
	private int _livesValue =10;
	private AudioSource[] _sounds;
	private AudioSource _gameOverSound;

	//Public instance varibles (for testing)
	public int birdNumber = 3;
	public GameObject bird;
	public GameObject dragon;
	public GameObject egg;
    public Text LivesLbl;
  	public Text ScoreLbl;

	//PUBLIC VARIBLES+++++++++++++++++++++++++++++++++++
	public int ScoreValue {
		get {
			return this._scoreValue; 
		}
		set {
			this._scoreValue = value;
			this.ScoreLbl.text = "Score: " + this._scoreValue;
		}
	}
	public int LivesValue {
		get {
			return this._livesValue; 
		}
		set {
			this._livesValue = value;
			this.LivesLbl.text = "Lives: " + this._livesValue;
			if (this._livesValue <= 0) {
				//calling the endgame method for when player runs out of lives
				this._endGame ();
			} 
		}
	}

	// Use this for initialization
	void Start () {
		//Creating the bird instances to be displayed on screen
		for (int birdCount = 0; birdCount < this.birdNumber; birdCount++) {
			Instantiate (this.bird);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	//changing scenes to the game over scene
	public void _endGame() {
		SceneManager.LoadScene ("End");
	}

}