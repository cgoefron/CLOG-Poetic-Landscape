using UnityEngine;
using System.Collections;

public class LightTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// When the player walks into a trigger on this gameobject
	void OnTriggerEnter (Collider other) {
            Debug.Log ("The Trigger is working!");
	// The light component on this game object, turn it off
		    gameObject.GetComponent<Light> ().enabled = false;
	}
	void OnTriggerExit (Collider other) {
			Debug.Log ("Some shit");
			gameObject.GetComponent<Light> ().enabled = true; 
		
}


}