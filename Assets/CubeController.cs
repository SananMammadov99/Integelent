using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	public float itme;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Mouse0)) {
			//Debug.Log ("Hello");
		}
	}

	void OnMouseDown(){
		rb.AddForce (new Vector3(0,1,0) * itme,ForceMode.VelocityChange);
	}
}
