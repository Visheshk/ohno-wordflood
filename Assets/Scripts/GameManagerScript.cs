using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		BoxScript.camShake = gameObject.AddComponent<CamShakeSimpleScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
