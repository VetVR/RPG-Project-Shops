using UnityEngine;
using System.Collections;

public class Rotarion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var myRotation = Quaternion.Euler(0, 0, 1); 
		transform.rotation *= myRotation; 
	}
}
