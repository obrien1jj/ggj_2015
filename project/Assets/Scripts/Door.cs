using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (){
		GameManager.Instance.GetComponent<RoomData> ().ClearRoom ();
		GameManager.Instance.GetComponent<RoomData> ().LoadRoom0 ();
		GameManager.Instance.GetComponent<RoomData> ().UpdateRoom ();

}
}