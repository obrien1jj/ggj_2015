using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour 
{
	protected Animator animator;
	protected Transform thisTransform;
	protected GameObject thisGameObject;
	protected Transform controllerXfrm;
	protected AnimatorStateInfo st;
	protected AnimatorStateInfo nst;

	protected Vector3 targetLocation;

	public CharacterController controller;



	virtual protected void Awake()
	{
		thisTransform = GetComponent<Transform>();
		thisGameObject = gameObject;
		
		controller = GetComponentInChildren<CharacterController>();
		controllerXfrm = controller.transform;

		if (animator == null)
			animator = controller.GetComponentInChildren<Animator>();
	}


	virtual protected void OnDestroy()
	{

	}
		
	// Update is called once per frame
	virtual protected void Update () {
	
		//empty
		//handle target location movment


	}


//	public void MoveTo(Ray ray)
//	{					
//		RaycastHit hit;
//		if ( Physics.Raycast(ray, out hit) && !UIManager.instance.DidAnyPointerHitUI())// && !performingAction)
//		{
//			float touchDist = (transform.position - hit.point).magnitude;
//			string hitGoName = AmFamUtils.GetHitItemsName(hit.transform);
//			
//			if (XMLData.houseHoldItems.ContainsKey(hitGoName) && XMLData.houseHoldItems[hitGoName].clickEnabled) // && hit.transform.Find(GetAttachPoint()) != null && thisAnimation[XMLData.houseHoldItems[hit.transform.gameObject.name].clickAction] != null)
//			{
//				StopMoving();
//				bool repair = false;
//				bool drivable = false;
//				if((XMLData.houseHoldItems[hitGoName].clickAction == eActionType.REPAIR || XMLData.houseHoldItems[hitGoName].clickAction == eActionType.WATCH_TV) && globalDataModel.AtHome)
//				{
//					string[] disasterTypes = XMLData.houseHoldItems[hitGoName].disaster.Split(':');
//					foreach(string disaster in disasterTypes)
//					{
//						DisasterType type = DisasterType.getTypeByName(disaster);
//						if(globalDataModel.houseHold.hasDisaster(type))
//						{
//							repair = true;
//							globalDataModel.disasterManager.displayDisasterDialog(type);
//						}
//					}
//					
//					drivable = (DrivingGameLauncher.IsDriveable(XMLData.houseHoldItems[hitGoName]) && Settings.DRIVING_FEATURE_ENABLED);
//				}
//				if(!repair)
//				{
//					if (drivable)
//					{
//						DrivingGameLauncher.instance.HandleVehicleClickAction(XMLData.houseHoldItems[hitGoName].key, XMLData.houseHoldItems[hitGoName].uid);
//					}
//					else if ((ezguiController.IsObjectOccupied(hit.transform.gameObject) == null) || XMLData.houseHoldItems[hitGoName].allowMultiple)
//					{
//						actionItemClickHandler(new ActionData(XMLData.houseHoldItems[hitGoName].clickAction, hit.transform.gameObject));
//					}
//				}
//				moving = false;
//			} else if (globalDataModel.AtHome && !performingAction) {
//				if ( touchDist > minimumDistanceToMove )
//				{
//					targetLocation = hit.point;
//				}
//				//				if(touchPhase == TouchPhase.Ended || touchPhase == TouchPhase.Canceled){
//				//					touching = false;
//				if (navigation != null) {
//					if ((thisAnimation.IsPlaying("idle")==false) && !moving) //TODO : find a better way to move character out of items
//					{
//						Debug.Log("not idling");
//						if (charSource) {
//							Debug.Log("calling move");
//							if(character.CharacterType != (int)eCharacterType.child)
//							{
//								soundFXManager.StopDance(character.CharacterType == (int)eCharacterType.player);
//							}
//							if (character.State == eCharacterState.sellingLemonade)
//							{
//								GameObject.Find("HouseGame").GetComponent<HouseGame>().stopLemonadeStand();
//							}
//							charSource.MoveToClosestOpenCell();
//							idle();
//						}
//					}
//					moving = true;
//					navigation.MoveToPosition(targetLocation, 0.5f);
//					
//					// Place a marker to indicate goal
//					PlaceMarker(new Vector3(targetLocation.x, 3, targetLocation.z));
//				}
//				//				} else {
//				//					touching = true;
//				//				}
//			}	
//		}
//	}
}
