using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	public int dTrust = -3;
	int V;
	// Use this for initialization
	void Start () {

		gameObject.rigidbody.AddRelativeForce (transform.forward, ForceMode.Impulse);
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision other) {

		if (other.gameObject.CompareTag ("Hero")) {
				//damage Trust
				other.gameObject.GetComponent<TrustValue> ().ChangeTrust (dTrust);
			}
		Destroy (this);
	}
}
