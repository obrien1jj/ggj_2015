using UnityEngine;
using System.Collections;

public class NavAi : MonoBehaviour {

	NavMeshAgent agent;
	Animator animator;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		animator = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space") == true) {
			agent.Stop (false);
			agent.SetDestination (Ivan.Instance.transform.position);
		}
		animator.SetFloat ("Speed", agent.velocity.magnitude);
	}

	public void GlobalForce (int dx, int dy, int dz) {
		agent.Stop (true);
		this.rigidbody.AddForce (dx, dy, dz, ForceMode.Impulse);
	}

	public void RelativeForce (int dx, int dy, int dz) {
		agent.Stop (true);
		this.rigidbody.AddRelativeForce (dx, dy, dz, ForceMode.Impulse);
	}
}
