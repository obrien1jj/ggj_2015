using UnityEngine;
using System.Collections;

public class TriggerTrap : MonoBehaviour {

	public int dTrust = 5;
	public bool leathal = false;
	public bool IsActive = true;

	// Use this for initialization
	void Start () {
		if (leathal == true)
						dTrust = -1000;
	}
	
	// Update is called once per frame
	void Update () {

	}

	// when Trap is triggered
	void OnTriggerEnter (Collider other) {
	
				// check if it the Hero on the trap
		if (isActive == true) {
			if (other.gameObject.CompareTag ("Hero")) {
				//damage Trust
				other.gameObject.GetComponent<TrustValue> ().ChangeTrust (dTrust);
				print (other.gameObject.GetComponent<TrustValue> ().Trust);
		
				// Trap is moved with animation

				//Move Hero
				other.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up);

			}
		}
	}
}

