using UnityEngine;
using System.Collections;

public class NyanCat : MonoBehaviour {

	void OnEnable() {
		Debug.Log ("I am enabled");
		StartCoroutine ("DebuggerRoutine");
	}

	void OnDisable() {
		Debug.Log ("I am disabled");
	}

	void OnDestroy() {
		Debug.Log ("GG");
	}

	void Awake() {
		Debug.Log ("I am Awake");
	}

	// Use this for initialization
	void Start () {
		Debug.Log ("I Started");

	}

	IEnumerator DebuggerRoutine() {

		while (true) {
			Debug.Log ("I'm calling every frame!");
		}
	}

	
	// Update is called once per frame
	void Update () { 
		GetComponent<SpriteRenderer> ().color = new Color (Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f)); //Green RGB		
	}
}
