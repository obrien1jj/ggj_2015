using UnityEngine;
using System.Collections;

public class ArrowShooter : MonoBehaviour {

	public GameObject Arrw;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		print ("boom boom motha fucka");
		//create instance of arrow
		GameObject.Instantiate (Arrw, this.transform.position, this.transform.rotation);
		//apply a velocity and vector3 to arrow
	}
}
