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

			RaycastHit hit;
			if ( Physics.Raycast(ray, out hit, 50, 1<<9) ) // && !UIManager.instance.DidAnyPointerHitUI())
			{
				
//				playerControls.PlaceMarker += PlaceDestinationMarker;
				MoveTo(hit.point);
				// Place a marker to indicate goal
				//PlaceMarker(new Vector3(targetLocation.x, 3, targetLocation.z));			
			}	
		}
		
	}


}
