using UnityEngine;
using System.Collections;

public class ChangeTrustCol : MonoBehaviour {

	public int dTrust = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other) {

		print ("test");
		Debug.Log ("weeee");
		if (other.gameObject.CompareTag ("Hero")) {
			print("test");
			other.gameObject.GetComponent<TrustValueTest>().ChangeTrust(dTrust);
			print (other.gameObject.GetComponent<TrustValueTest>().Trust);
		}
	}
}

