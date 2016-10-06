using UnityEngine;
using System.Collections;

public class DragonController : MonoBehaviour {
	// PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private AudioSource[] _sounds;
	private AudioSource _hurtSound;
	private AudioSource _eggSound;


	//Public INSTANCE VARIBLES (for testing)
	public GameController gameController;

	// Use this for initialization
	void Start () {
		this._transform = this.GetComponent<Transform> ();
		//getting sounds and assigning them to right varible
		this._sounds = this.GetComponents<AudioSource> ();
		this._hurtSound = this._sounds [1];
		this._eggSound = this._sounds [2];
	}
	
	// Update is called once per frame
	void Update () {
		this._move ();
	}

	/**
	 * this method moves the game object across the x-axis following the mouse movement
	 */
	private void _move() {
		this._transform.position = new Vector2 (Mathf.Clamp(Input.mousePosition.x - 320f,-290f, 290f), -200f);
	}

	private void OnTriggerEnter2D(Collider2D other) {
		//collision manager
		if (other.gameObject.CompareTag ("Egg")) {
			Debug.Log ("Egg Hit!");
			this.gameController.ScoreValue += 100;
			this._eggSound.Play ();
		}
		if (other.gameObject.CompareTag ("Bird")) {
			Debug.Log ("Bird Hit!");
			this.gameController.LivesValue -= 1;
			this._hurtSound.Play ();
		}

	}
		
}
