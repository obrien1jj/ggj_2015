using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class FloorSwitch : MonoBehaviour {

	public bool Activated = false;
	List<GameObject> TrapList = new List<GameObject>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter() {
		if (Activated == false) {
			foreach (GameObject t in TrapList) {
				t.GetComponent<TriggerTrap>().IsActive = false;
			}
		}
		Activated = true;

	}
}
