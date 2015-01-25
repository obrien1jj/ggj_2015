using UnityEngine;
using System.Collections;

public class TriggerTrap : MonoBehaviour {

	public int dTrust = 5;
	public bool IsLethal = false;
	public bool IsActive = true;
	public bool IsChest = true;
	public int AnimSpeed = 1;
	public int dx;
	public int dy;
	public int dz;

	// Use this for initialization
	void Start () {
		if (IsLethal == true)
						dTrust = -1000;
	}
	
	// Update is called once per frame
	void Update () {

	}

	// when Trap is triggered
	void OnTriggerEnter (Collider other) {
	
				// check if it the Hero on the trap
		if (IsActive == true) {
			if (other.gameObject.CompareTag ("Hero")) {
				//damage Trust
				other.gameObject.GetComponent<TrustValue> ().ChangeTrust (dTrust);
				print (other.gameObject.GetComponent<TrustValue> ().trust);
		
				// Trap is moved with animation
				if (IsChest == false)
				//Move Hero
					other.gameObject.GetComponent<Rigidbody> ().AddForce (dx, dy, dz);
				else
					IsActive = false;
				animation.Play ("Take 001");
				animation["Take 001"].speed = AnimSpeed;

			}
		}
	}
}

