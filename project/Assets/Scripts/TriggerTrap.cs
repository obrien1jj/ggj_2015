using UnityEngine;
using System.Collections;

public class TriggerTrap : MonoBehaviour {

	public int dTrust = 5;
	public bool IsLethal = false;
	public bool IsActive = true;
	public bool IsChest = true;
	public bool IsAxe = false;
	public bool IsArrow = false;
	public int AnimSpeed = 1;
	public bool GlobalF = true;
	public int dx;
	public int dy;
	public int dz;

	// Use this for initialization
	void Start () {
		if (IsLethal == true)
						dTrust = -1000;
		//print ("I am on");
	}
	
	// Update is called once per frame
	void Update () {

	}

	// when Trap is triggered
	IEnumerator OnTriggerEnter (Collider other) {

		//print ("I have been hit");
	
				// check if it the Hero on the trap
		if (IsActive == true) {

			//print ("I am active");
			if (other.gameObject.CompareTag ("Hero")) {

				//damage Trust
				other.gameObject.GetComponent<TrustValue> ().ChangeTrust (dTrust);
				//print (other.gameObject.GetComponent<TrustValue> ().trust);
				if (IsAxe == true) {
					if (GlobalF == true)
						other.gameObject.GetComponent<NavAi> ().GlobalForce (dx, dy, dz);
					else
						other.gameObject.GetComponent<NavAi> ().RelativeForce (dx, dy, dz);
				}
				if ( IsAxe != true) {
				animation.Play ("Take 001");
				animation["Take 001"].speed = AnimSpeed;
				if (IsChest == false){
				//Move Hero

					if (GlobalF == true)
						other.gameObject.GetComponent<NavAi> ().GlobalForce (dx, dy, dz);
					else
						other.gameObject.GetComponent<NavAi> ().RelativeForce (dx, dy, dz);

					yield return new WaitForSeconds ((animation.clip.length/AnimSpeed));
					animation["Take 001"].speed = -AnimSpeed;
					animation.Play ("Take 001");

				}
				else
					IsActive = false;
				}
			}
		}
	}
}

