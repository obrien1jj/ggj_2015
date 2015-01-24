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

	public Material actionModeTintMaterial;

	public CharacterController controller;

	private bool _actionMode;
	protected bool actionMode {
		get { return _actionMode; }
		set 
		{
			if (_actionMode != value)
			{
				Color temp = actionModeTintMaterial.color;
				temp.a = value?0.4f:0;
				actionModeTintMaterial.color = temp;
				_actionMode = value;
			}

		}
	}

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
	
		actionMode = Input.GetKey(KeyCode.Space);



	}
}
