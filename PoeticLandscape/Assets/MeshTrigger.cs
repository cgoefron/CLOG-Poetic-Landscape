using UnityEngine;
using System.Collections;

public class MeshTrigger : MonoBehaviour {

	
	void OnTriggerEnter() {
		gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
		
		//find the sphere and turn it off
		GameObject.Find ("Sphere").SetActive(false);

		//Destroy(GameObject.Find("Sphere") );
	}

}
