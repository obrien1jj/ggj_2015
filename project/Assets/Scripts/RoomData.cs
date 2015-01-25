using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RoomData : MonoBehaviour {
	public enum TileType {NullObj, AxeX, AxeZ, ChestXp, ChestXn, ChestZp, ChestZn, 
		Pillar, PistonXp, PistonXn, PistonZp, PistonZn,
		Spikes, SwitchXp, SwitchXn, SwitchZp, SwitchZn, SwitchYp, TheBigSpike};
	
	//a matrix of the room's layout
	TileType[,] layout = new TileType[8, 8];
	
	//what doors does this room have?  these are inside the wall so they aren't a tile.
	bool door_top_right;
	bool door_bot_right;
	bool door_bot_left;
	bool door_top_left;
	
	//a list of all the traps in the room
	List<GameObject> trap_list = new List<GameObject>();
	
	
	
	// Use this for initialization
	void Start () {
		layout [0, 0] = TileType.ChestXp;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void UpdateRoom(){
		for (int j = 0; j < 8; j++) {
			for(int i=0; i < 8; i++){
				TileType ObjType = layout[i,j];
				switch(ObjType)
				{
				case TileType.AxeX:
					Instantiate(Resources.Load(AxeX), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.AxeZ:
					Instantiate(Resources.Load(AxeZ), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.ChestXp:
					Instantiate(Resources.Load(ChestXp), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.ChestXn:
					Instantiate(Resources.Load(ChestXn), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.ChestZp:
					Instantiate(Resources.Load(ChestZp), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.ChestZn:
					Instantiate(Resources.Load(ChestZn), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.Pillar:
					Instantiate(Resources.Load(Pillar), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.PistonXp:
					Instantiate(Resources.Load(PistonXp), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.PistonXn:
					Instantiate(Resources.Load(PistonXn), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.PistonZp:
					Instantiate(Resources.Load(PistonZp), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.PistonZn:
					Instantiate(Resources.Load(PistonZn), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.Spikes:
					Instantiate(Resources.Load(Spikes), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.SwitchXp:
					Instantiate(Resources.Load(SwitchXp), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.SwitchXn:
					Instantiate(Resources.Load(SwitchXn), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.SwitchZp:
					Instantiate(Resources.Load(SwitchZp), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.SwitchZn:
					Instantiate(Resources.Load(SwitchZn), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.SwitchYp:
					Instantiate(Resources.Load(SwitchYp), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.TheBigSpike:
					Instantiate(Resources.Load(TheBigSpike), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), new Vector3(0, 0, 0));
					break;
				case TileType.NullObj:
					break;
				}
			}
		}
	}
}