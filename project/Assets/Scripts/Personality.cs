using UnityEngine;
using System.Collections;


//basically, this is how much trust they start with, how much trust they get from treasure, and how much they lose from traps, how much they lose fro hitting a bunch of traps
public class Personality : MonoBehaviour {
	public enum Personality_Type {ambitious, cautious, rugged, feeble, forgiving, harsh, unquestioning, skeptical, greedy, pious};
	//ambitious		|	cautious	:	how much trust the hero starts with
	//rugged		|	feeble		:   how much the hero loses from a single trap
	//forgiving		|	harsh		:   how much the hero loses from hitting a bunch of traps
	//unquestioning	|	skeptical	:	how much trust the hero gets from completing a room
	//greedy		|	pious		:	how much trust the hero gets from finding treasure
	//numbers and stuff for the 3 things
	public Personality_Type attitude = Personality_Type.ambitious;
	// Use this for initialization
	void Start () {
		//gameObject.GetComponent <TrustValueTest>().Trust = 50;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//eamg
	//takes the stats and generates player-facing traits from their values
	void generate_traits(){
		
	}
}
