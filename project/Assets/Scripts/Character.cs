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

	// Use this for initialization
	void Start () {
	
	}

	virtual protected void OnDestroy()
	{

	}
		
	// Update is called once per frame
	void Update () {
	
	}
}
