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
	// will have position
	bool DoorTopRight;
	bool DoorBotRight;
	bool DoorBotLeft;
	bool DoorTopLeft;
	
	//a list of all the traps in the room
	List<GameObject> TrapList = new List<GameObject> ();

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
					Instantiate(Resources.Load("AxeX"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.AxeZ:
					Instantiate(Resources.Load("AxeZ"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.ChestXp:
					Instantiate(Resources.Load("ChestXp"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.ChestXn:
					Instantiate(Resources.Load("ChestXn"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.ChestZp:
					Instantiate(Resources.Load("ChestZp"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.ChestZn:
					Instantiate(Resources.Load("ChestZn"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.Pillar:
					Instantiate(Resources.Load("Pillar"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.PistonXp:
					Instantiate(Resources.Load("PistonXp"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.PistonXn:
					Instantiate(Resources.Load("PistonXn"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.PistonZp:
					Instantiate(Resources.Load("PistonZp"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.PistonZn:
					Instantiate(Resources.Load("PistonZn"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.Spikes:
					Instantiate(Resources.Load("Spikes"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.SwitchXp:
					Instantiate(Resources.Load("SwitchXp"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.SwitchXn:
					Instantiate(Resources.Load("SwitchXn"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.SwitchZp:
					Instantiate(Resources.Load("SwitchZp"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.SwitchZn:
					Instantiate(Resources.Load("SwitchZn"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.SwitchYp:
					Instantiate(Resources.Load("SwitchYp"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.TheBigSpike:
					Instantiate(Resources.Load("TheBigSpike"), new Vector3((float)(i * 1.25 - 4.5), (float)(j * -1.25 + 4.5), 0), Quaternion.identity) ;
					break;
				case TileType.NullObj:
					break;
				}
			}
		}
	}
	void LoadRoom0 () {
		// Doors @ B, T
		int RoomNum = 0;
		layout[0, 2] = TileType.Spikes;
		layout[0, 3] = TileType.SwitchYp;
		layout[0, 4] = TileType.Spikes;
		layout[1, 2] = TileType.Spikes;
		layout[1, 3] = TileType.TheBigSpike;
		layout[1, 4] = TileType.Spikes;
		layout[2, 2] = TileType.Spikes;
		layout[2, 3] = TileType.Spikes;
		layout[2, 4] = TileType.Spikes;
	}

	void LoadRoom1() {
		// Doors @ B, L, T, R
		int RoomNum = 1;
		layout[0, 2] = TileType.TheBigSpike;
		layout[0, 3] = TileType.Spikes;
		layout[0, 4] = TileType.TheBigSpike;
		layout[0, 5] = TileType.Spikes;

		layout[1, 2] = TileType.TheBigSpike;
		layout[1, 4] = TileType.TheBigSpike;

		layout[2, 0] = TileType.TheBigSpike;
		layout[2, 1] = TileType.TheBigSpike;
		layout[2, 2] = TileType.TheBigSpike;
		layout[2, 4] = TileType.TheBigSpike;

		layout[3, 4] = TileType.TheBigSpike;
		layout[3, 5] = TileType.TheBigSpike;

		layout[4, 4] = TileType.TheBigSpike;
		layout[4, 5] = TileType.SwitchYp;
		layout[4, 6] = TileType.Pillar;
		layout[4, 7] = TileType.TheBigSpike;

		layout[5, 0] = TileType.TheBigSpike;
		layout[5, 1] = TileType.TheBigSpike;
		layout[5, 2] = TileType.TheBigSpike;
		layout[5, 3] = TileType.TheBigSpike;
		layout[5, 4] = TileType.TheBigSpike;
		layout[5, 5] = TileType.TheBigSpike;
		layout[5, 5] = TileType.TheBigSpike;

		layout[6, 3] = TileType.Spikes;
		layout[6, 4] = TileType.TheBigSpike;
		layout[6, 7] = TileType.PistonXn;

		layout[7, 3] = TileType.SwitchXn;
		layout[7, 4] = TileType.TheBigSpike;
	}
	void LoadRoom2() {
		// Doors @ B, L, T, R
		int RoomNum = 2;
		layout[0, 0] = TileType.PistonXp;
		layout[0, 3] = TileType.PistonXp;
		layout[0, 6] = TileType.PistonZp;

		layout[1, 0] = TileType.SwitchZn;
		layout[1, 1] = TileType.PistonZn;
		layout[1, 3] = TileType.TheBigSpike;
		layout[1, 4] = TileType.TheBigSpike;
		layout[1, 5] = TileType.TheBigSpike;
		layout[1, 6] = TileType.SwitchYp;

		layout[2, 0] = TileType.TheBigSpike;
		layout[2, 1] = TileType.SwitchYp;
		layout[2, 2] = TileType.PistonZp;
		layout[2, 3] = TileType.TheBigSpike;
		layout[2, 4] = TileType.SwitchYp;
		layout[2, 5] = TileType.TheBigSpike;

		layout[3, 0] = TileType.TheBigSpike;
		layout[3, 1] = TileType.PistonZn;
		layout[3, 2] = TileType.SwitchYp;
		layout[3, 3] = TileType.TheBigSpike;
		layout[3, 4] = TileType.TheBigSpike;
		layout[3, 5] = TileType.TheBigSpike;
		layout[3, 6] = TileType.TheBigSpike;
		layout[3, 7] = TileType.TheBigSpike;

		layout[4, 0] = TileType.TheBigSpike;
		layout[4, 1] = TileType.SwitchYp;
		layout[4, 2] = TileType.PistonZp;
		layout[4, 3] = TileType.TheBigSpike;
		layout[4, 5] = TileType.Spikes;
		layout[4, 6] = TileType.TheBigSpike;
		layout[4, 7] = TileType.Spikes;

		layout[5, 0] = TileType.TheBigSpike;
		layout[5, 1] = TileType.PistonZn;
		layout[5, 2] = TileType.SwitchYp;
		layout[5, 3] = TileType.TheBigSpike;
		layout[5, 4] = TileType.TheBigSpike;
		layout[5, 5] = TileType.TheBigSpike;
		layout[5, 6] = TileType.TheBigSpike;
		layout[5, 7] = TileType.TheBigSpike;

		layout[6, 0] = TileType.TheBigSpike;
		layout[6, 1] = TileType.SwitchYp;
		layout[6, 3] = TileType.TheBigSpike;
		layout[6, 5] = TileType.TheBigSpike;
		layout[6, 6] = TileType.Spikes;
		layout[6, 7] = TileType.Spikes;

		layout[7, 1] = TileType.TheBigSpike;
		layout[7, 2] = TileType.TheBigSpike;
	}
	void LoadRoom3() {
		// Doors @ B, L, T, R
		int RoomNum = 3;
		layout[0, 3] = TileType.Spikes;
		layout[0, 4] = TileType.PistonZn;
		layout[0, 5] = TileType.SwitchZn;
		layout[0, 6] = TileType.PistonZn;
		
		layout[1, 0] = TileType.PistonZn;
		layout[1, 2] = TileType.TheBigSpike;
		layout[1, 3] = TileType.Spikes;
		layout[1, 5] = TileType.TheBigSpike;
		layout[1, 7] = TileType.PistonZn;
		
		layout[2, 1] = TileType.TheBigSpike;
		layout[2, 2] = TileType.TheBigSpike;
		layout[2, 3] = TileType.PistonZn;
		layout[2, 5] = TileType.TheBigSpike;
		layout[2, 6] = TileType.Spikes;
		
		layout[3, 0] = TileType.PistonZn;
		layout[3, 1] = TileType.PistonZn;
		layout[3, 2] = TileType.TheBigSpike;
		layout[3, 3] = TileType.PistonZn;
		layout[3, 4] = TileType.PistonZn;
		layout[3, 5] = TileType.TheBigSpike;
		
		layout[4, 1] = TileType.Spikes;
		layout[4, 2] = TileType.TheBigSpike;
		layout[4, 4] = TileType.Spikes;
		layout[4, 5] = TileType.TheBigSpike;
		
		layout[5, 2] = TileType.TheBigSpike;
		layout[5, 3] = TileType.PistonZn;
		layout[5, 4] = TileType.PistonZn;
		layout[5, 5] = TileType.TheBigSpike;
		
		layout[6, 2] = TileType.TheBigSpike;
		layout[6, 4] = TileType.TheBigSpike;
		layout[6, 5] = TileType.TheBigSpike;
		layout[6, 6] = TileType.PistonZn;
		layout[6, 7] = TileType.PistonZn;
		
		layout[7, 2] = TileType.PistonXn;
		layout[7, 3] = TileType.Spikes;
	}
	void LoadRoom4() {
		// Doors @ B, L, T, R
		int RoomNum = 4;
		
		layout[0, 0] = TileType.TheBigSpike;
		layout[0, 5] = TileType.TheBigSpike;
		layout[0, 6] = TileType.TheBigSpike;
		
		layout[1, 0] = TileType.TheBigSpike;
		layout[1, 2] = TileType.TheBigSpike;
		layout[1, 3] = TileType.TheBigSpike;
		layout[1, 5] = TileType.TheBigSpike;
		layout[1, 6] = TileType.TheBigSpike;

		layout[2, 0] = TileType.TheBigSpike;
		layout[2, 2] = TileType.TheBigSpike;
		layout[2, 3] = TileType.TheBigSpike;
		layout[2, 5] = TileType.TheBigSpike;
		layout[2, 6] = TileType.TheBigSpike;
		
		layout[3, 0] = TileType.TheBigSpike;
		layout[3, 2] = TileType.TheBigSpike;
		layout[3, 3] = TileType.Spikes;
		layout[3, 5] = TileType.TheBigSpike;
		layout[3, 6] = TileType.TheBigSpike;
		
		layout[4, 0] = TileType.TheBigSpike;
		layout[4, 2] = TileType.TheBigSpike;
		layout[4, 3] = TileType.TheBigSpike;
		layout[4, 5] = TileType.TheBigSpike;
		layout[4, 6] = TileType.Spikes;
		
		layout[5, 0] = TileType.TheBigSpike;
		layout[5, 2] = TileType.TheBigSpike;
		layout[5, 3] = TileType.TheBigSpike;
		layout[5, 5] = TileType.TheBigSpike;
		layout[5, 6] = TileType.TheBigSpike;
		
		layout[6, 0] = TileType.TheBigSpike;
		layout[6, 2] = TileType.TheBigSpike;
		layout[6, 3] = TileType.TheBigSpike;
		layout[6, 5] = TileType.TheBigSpike;
		layout[6, 6] = TileType.TheBigSpike;
		
		layout[7, 0] = TileType.SwitchZn;
		layout[7, 2] = TileType.PistonZn;
		layout[7, 3] = TileType.SwitchZn;
	}


	void LoadRoom5() {
		// Doors @ B, L, T, R
		int RoomNum = 5;
		
		layout[0, 0] = TileType.SwitchZn;
		layout[0, 2] = TileType.TheBigSpike;
		layout[0, 5] = TileType.TheBigSpike;
		layout[0, 7] = TileType.PistonZp;
		
		layout[1, 0] = TileType.PistonXp;
		layout[1, 1] = TileType.PistonXp;
		layout[1, 2] = TileType.TheBigSpike;
		layout[1, 3] = TileType.Spikes;
		layout[1, 5] = TileType.TheBigSpike;
		layout[1, 6] = TileType.PistonZp;

		layout[2, 0] = TileType.TheBigSpike;
		layout[2, 1] = TileType.TheBigSpike;
		layout[2, 2] = TileType.TheBigSpike;
		layout[2, 3] = TileType.TheBigSpike;
		layout[2, 4] = TileType.TheBigSpike;
		layout[2, 5] = TileType.TheBigSpike;
		layout[2, 6] = TileType.TheBigSpike;
		layout[2, 7] = TileType.TheBigSpike;
		
		layout[3, 2] = TileType.TheBigSpike;
		layout[3, 3] = TileType.Spikes;
		layout[3, 5] = TileType.TheBigSpike;
		layout[3, 6] = TileType.Spikes;

		layout[4, 0] = TileType.TheBigSpike;
		layout[4, 1] = TileType.TheBigSpike;
		layout[4, 2] = TileType.TheBigSpike;
		layout[4, 3] = TileType.Spikes;
		layout[4, 5] = TileType.TheBigSpike;
		layout[4, 7] = TileType.Spikes;
		
		layout[5, 0] = TileType.TheBigSpike;
		layout[5, 1] = TileType.TheBigSpike;
		layout[5, 2] = TileType.TheBigSpike;
		layout[5, 3] = TileType.TheBigSpike;
		layout[5, 4] = TileType.TheBigSpike;
		layout[5, 5] = TileType.TheBigSpike;
		layout[5, 6] = TileType.TheBigSpike;
		layout[5, 7] = TileType.TheBigSpike;
		
		layout[6, 2] = TileType.TheBigSpike;
		layout[6, 3] = TileType.Spikes;
		layout[6, 5] = TileType.TheBigSpike;
		layout[6, 6] = TileType.Spikes;

		layout[7, 0] = TileType.PistonXn;
		layout[7, 1] = TileType.PistonXn;
		layout[7, 2] = TileType.TheBigSpike;
		layout[7, 4] = TileType.PistonXn;
		layout[7, 5] = TileType.TheBigSpike;
	}

	void LoadRoom6() {
		// Doors @ B, L, T, R
		int RoomNum = 6;

		layout[0, 6] = TileType.TheBigSpike;

		layout[1, 1] = TileType.Spikes;
		layout[1, 4] = TileType.Spikes;
		layout[1, 5] = TileType.TheBigSpike;

		layout[2, 0] = TileType.TheBigSpike;
		layout[2, 3] = TileType.Spikes;
		layout[2, 4] = TileType.TheBigSpike;
		layout[2, 5] = TileType.Spikes;

		layout[3, 0] = TileType.SwitchZn;
		layout[3, 1] = TileType.TheBigSpike;
		layout[3, 2] = TileType.TheBigSpike;
		layout[3, 4] = TileType.Spikes;
		layout[3, 6] = TileType.TheBigSpike;

		layout[4, 2] = TileType.Spikes;
		layout[4, 4] = TileType.TheBigSpike;
		layout[4, 6] = TileType.TheBigSpike;

		layout[5, 0] = TileType.TheBigSpike;
		layout[5, 1] = TileType.TheBigSpike;
		layout[5, 2] = TileType.TheBigSpike;
		layout[5, 3] = TileType.Spikes;
		layout[5, 4] = TileType.Spikes;
		layout[5, 5] = TileType.TheBigSpike;
		layout[5, 6] = TileType.Spikes;

		layout[6, 1] = TileType.Spikes;
		layout[6, 3] = TileType.TheBigSpike;
		layout[6, 5] = TileType.Spikes;

		layout[7, 4] = TileType.TheBigSpike;

	}
	void LoadRoom7() {
		// Doors @ B, L, T, R
		int RoomNum = 7;
		
		layout[0, 0] = TileType.Pillar;
		layout[0, 1] = TileType.PistonXp;
		layout[0, 2] = TileType.PistonXp;
		layout[0, 3] = TileType.PistonXp;
		layout[0, 4] = TileType.PistonXp;
		layout[0, 5] = TileType.PistonXp;
		layout[0, 6] = TileType.PistonXp;
		layout[0, 7] = TileType.PistonXp;
		
		layout[1, 0] = TileType.PistonZn;
		layout[1, 7] = TileType.PistonZp;
		
		layout[2, 0] = TileType.PistonZn;
		layout[2, 2] = TileType.AxeZ;
		layout[2, 3] = TileType.PistonZn;
		layout[2, 7] = TileType.PistonZp;
		
		layout[3, 0] = TileType.PistonZn;
		layout[3, 1] = TileType.ChestZn;
		layout[3, 2] = TileType.Spikes;
		layout[3, 3] = TileType.PistonZn;
		layout[3, 7] = TileType.PistonZp;
		
		layout[4, 0] = TileType.PistonZn;
		layout[4, 2] = TileType.Spikes;
		layout[4, 3] = TileType.PistonZn;
		layout[4, 7] = TileType.PistonZp;
		
		layout[5, 0] = TileType.PistonZn;
		layout[5, 2] = TileType.AxeZ;
		layout[5, 3] = TileType.PistonZn;
		layout[5, 7] = TileType.PistonZp;
		
		layout[6, 0] = TileType.PistonZn;
		layout[6, 7] = TileType.PistonZp;
		
		layout[7, 0] = TileType.Pillar;
		layout[7, 1] = TileType.Spikes;
		layout[7, 2] = TileType.PistonZn;
		layout[7, 3] = TileType.SwitchZn;
		layout[7, 4] = TileType.PistonZn;
		layout[7, 5] = TileType.Spikes;
		layout[7, 6] = TileType.PistonZn;
		layout[7, 7] = TileType.Pillar;
	}
}