using UnityEngine;
using System.Collections;

public class RoomData : MonoBehaviour {


	public enum Tile_Type {small_spike, big_spike, pusher, arrow_trap, lever, pit, holes, walls, key, gate};



	public Tile_Type test = Tile_Type.small_spike;

	//a matrix of the room's layout
	Tile_Type[,] myArray = new Tile_Type[8,8];

	//what doors does this room have?  these are inside the wall so they aren't a tile.
	bool door_top_right;
	bool door_bot_right;
	bool door_bot_left;
	bool door_top_left;

	// Use this for initialization
	void Start () {
		myArray[0, 0] = test;
		print (myArray[0,0]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
