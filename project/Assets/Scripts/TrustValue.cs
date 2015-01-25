using UnityEngine;
using System.Collections;

public class TrustValue : MonoBehaviour {

	public int trust;


	/////////////////////
	//NOTE:  THE 8 HEROES HAVE PRESET TRAIT LEVELS, SO THEY WON'T BE RANDOM
	//BUT THERE MIGHT BE MORE HEROES THAT DO HAVE RANDOM TRAITS
	/////////////////////

	//base starting trust
	int base_trust = 80;
	//ambitious		|	cautious	:	how much trust the hero starts with
	public int ambition;  //used to be "startTrust"
	//rugged		|	feeble		:   how much the hero loses from a single trap
	public int ruggedness;
	//forgiving		|	harsh		:   how much the hero loses from hitting a bunch of traps
	public int harshness;
	//unquestioning	|	skeptical	:	how much trust the hero gets from completing a room
	public int suspicion;
	//greedy		|	pious		:	how much trust the hero gets from finding treasure
	public int greed;

	// Use this for initialization
	void Start () {
		ambition = (int)Random.Range (-20.0F, 20.0F);
		ruggedness = (int)Random.Range (-20.0F, 20.0F);
		harshness = (int)Random.Range (-20.0F, 20.0F);
		suspicion = (int)Random.Range (-20.0F, 20.0F);
		greed = (int)Random.Range (-20.0F, 20.0F);
		trust = base_trust + ambition;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeTrust (int dTrustVal) {
		trust += dTrustVal;
		gameObject.GetComponent<TrustBar>().updateBar ((float)trust/(base_trust+ambition));
	}
}
