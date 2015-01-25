using UnityEngine;
using System.Collections;

public class OnDeath : MonoBehaviour {
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void Do_Stuff(){
		//play some dialogues

		this.GetComponent<Personality>().play_dialogue(this.GetComponent<Personality>().run_out_of_trust);
		//make hero run off into a random adjacent room
		//prevent action mode from activating
		//destroy the hero object
		//make a dead body in that room
		
		
		
	}
}

/*
 * matrix of references to tiles or something
 */

