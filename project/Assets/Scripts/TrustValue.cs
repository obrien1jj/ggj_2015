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
		TrustBar.Instance.gameObject.GetComponent<TrustBar>().updateBar ((float)trust/100);



	}
	
	// Update is called once per frame
	void Update () {

	}

	public void ChangeTrust (int dTrustVal) {
		//if it's healing
		if (dTrustVal > 0) {
			this.GetComponent<Personality>().play_dialogue(this.GetComponent<Personality>().cleared_room);
			trust += dTrustVal;
			trust = Mathf.Min (trust, 100);
		}
		//if it's hurting
		else{

			trust += dTrustVal;
			trust = Mathf.Max (trust, 0);
			if (trust > 0){
				this.GetComponent<Personality>().play_dialogue(this.GetComponent<Personality>().hit_by_trap);
			}
		}
		TrustBar.Instance.gameObject.GetComponent<TrustBar>().updateBar ((float)trust/100);
		//if all trust has been lost
		if (trust <= 0) {
			this.GetComponent<Personality>().play_dialogue(this.GetComponent<Personality>().run_out_of_trust);
			this.GetComponent<OnDeath>().Do_Stuff();
		}
	}
}
