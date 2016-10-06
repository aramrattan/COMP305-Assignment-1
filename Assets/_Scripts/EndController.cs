using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndController : MonoBehaviour {

	public Button RestartButton;
	//public Text FinalScore;

	//private GameController gameScore = new GameController();

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//chaanging back to the game scene
	public void RestartButton_Click(){
		SceneManager.LoadScene ("Game");

	}
}
