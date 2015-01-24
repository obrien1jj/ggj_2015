using UnityEngine;
using System.Collections;

public class IvanCharacter : Character 
{


	// Update is called once per frame
	override protected void Update () {
		base.Update();
		
		if (!GameManager.Instance.actionMode && Input.GetKeyDown(KeyCode.Mouse0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//			playerControls.PlaceMarker += PlaceDestinationMarker;
			MoveTo(ray);
		}
		
	}


}
