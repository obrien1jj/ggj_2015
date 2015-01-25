using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RoomData : MonoBehaviour {
	public enum Tile_Type {small_spike, big_spike, pusher, arrow_trap, lever, pit, holes, walls, key, gate};

	public Tile_Type test = Tile_Type.small_spike;

	//a matrix of the room's layout
	Tile_Type[,] layout = new Tile_Type[8,8];

	//what doors does this room have?  these are inside the wall so they aren't a tile.
	bool door_top_right;
	bool door_bot_right;
	bool door_bot_left;
	bool door_top_left;

	//a list of all the traps in the room
	List<GameObject> trap_list = new List<GameObject>();



	// Use this for initialization
	void Start () {
		layout[0, 0] = test;
		print (layout[0,0]);

		foreach (Tile_Type element in layout) {
			trap_list.Add(element);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
