using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class FloorSwitch : MonoBehaviour {

	public bool ManyThings = false;
	public bool Activated = false;
	public int AnimSpeed = 1;
	public GameObject thing;

	List<GameObject> TrapList = new List<GameObject>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter() {
		if (Activated == false) {

			animation.Play ("Take 001");
			animation ["Take 001"].speed = AnimSpeed;

			if (ManyThings == true)
				DoTheManyThings ();
			else 
				DoTheThing ();
		}
		Activated = true;
	}
	

	void DoTheThing () {
		print ("i am doing the thing");
		thing.GetComponent<TriggerTrap> ().IsActive = false;
	}

	void DoTheManyThings () {
		foreach (GameObject t in TrapList) {
			t.GetComponent<TriggerTrap> ().IsActive = false;
		}
	}
}
