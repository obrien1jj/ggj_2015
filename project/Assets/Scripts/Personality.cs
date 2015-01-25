using UnityEngine;
using System.Collections;
using System.Collections.Generic;


//basically, this is how much trust they start with, how much trust they get from treasure, and how much they lose from traps, how much they lose fro hitting a bunch of traps
public class Personality : MonoBehaviour {

	//ambitious		|	cautious	:	how much trust the hero starts with
	//rugged		|	feeble		:   how much the hero loses from a single trap
	//forgiving		|	harsh		:   how much the hero loses from hitting a bunch of traps
	//unquestioning	|	skeptical	:	how much trust the hero gets from completing a room
	//greedy		|	pious		:	how much trust the hero gets from finding treasure
	//numbers and stuff for the 3 things
	//public enum Personality_Type {ambitious, cautious, rugged, feeble, forgiving, harsh, unquestioning, skeptical, greedy, pious};
	//public Personality_Type attitude = Personality_Type.ambitious;


	AudioClip MyAudio;

	public List<AudioClip> cleared_room = new List<AudioClip>();
	public List<AudioClip> hit_by_trap = new List<AudioClip>();
	public List<AudioClip> opens_treasure_chest = new List<AudioClip>();
	public List<AudioClip> run_out_of_trust = new List<AudioClip>();
	public List<AudioClip> upon_selection = new List<AudioClip>();


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {


	}

	public void play_dialogue(List<AudioClip> g_audio_list){
		AudioSource.PlayClipAtPoint(g_audio_list[(int)Random.Range (0.0F, g_audio_list.Count)], transform.position);
	}     




	//takes the stats and generates player-facing traits from their values
	void generate_traits(){
		
	}
}
