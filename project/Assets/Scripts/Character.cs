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
	protected bool moving;
	private Vector3 velocity;
	public float speed;

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
	virtual protected void Update () 
	{


		
		Vector3 movement = Vector3.zero;
		
		if ( moving )
		{
			// Move towards the target location
			movement = targetLocation - controllerXfrm.position;
			movement.y = 0;
			float dist = movement.magnitude;
			
			if( dist < 0.01f )
			{
				moving = false;
			}
			else
			{
				movement = movement.normalized * speed;
			}
		}
		
		//		if ( !controller.isGrounded )
//		{			
//			// Apply gravity to our velocity to diminish it over time
//			velocity.y += Physics.gravity.y * Time.deltaTime;
//			
//			// Adjust additional movement while in-air
//			movement.x *= inAirMultiplier;
//			movement.z *= inAirMultiplier;
//		}
		
		movement += velocity;		
//		movement += Physics.gravity;
		movement *= Time.smoothDeltaTime;
		
		// Actually move the character
		controller.Move( movement );
		
		if ( controller.isGrounded )
			// Remove any persistent velocity after landing
			velocity = Vector3.zero;
		
		// Face the character to match with where she is moving	
		FaceMovementDirection();

		//empty
		//handle target location movment


	}


	private void FaceMovementDirection()
	{
		Vector3 horizontalVelocity = controller.velocity;
		horizontalVelocity.y = 0; // Ignore vertical movement
		
		// If moving significantly in a new direction, point that character in that direction
		if ( horizontalVelocity.magnitude > 0.1 )
			controllerXfrm.forward = horizontalVelocity.normalized;
	}

	public void MoveTo(Ray ray)
	{					

		RaycastHit hit;
		if ( Physics.Raycast(ray, out hit) ) // && !UIManager.instance.DidAnyPointerHitUI())
		{

				targetLocation = hit.point;

				moving = true;
				
				// Place a marker to indicate goal
				//PlaceMarker(new Vector3(targetLocation.x, 3, targetLocation.z));

		}	
	}
}
