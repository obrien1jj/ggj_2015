using UnityEngine;
using System.Collections;

public class NavAi : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space") == true) {
			GetComponent<NavMeshAgent> ().Stop (false);
			GetComponent<NavMeshAgent> ().SetDestination (Ivan.Instance.transform.position);
		}
	}

	public void GlobalForce (int dx, int dy, int dz) {
		GetComponent<NavMeshAgent> ().Stop (true);
		this.rigidbody.AddForce (dx, dy, dz, ForceMode.Impulse);
	}

	public void RelativeForce (int dx, int dy, int dz) {
		GetComponent<NavMeshAgent> ().Stop (true);
		this.rigidbody.AddRelativeForce (dx, dy, dz, ForceMode.Impulse);
	}
}
