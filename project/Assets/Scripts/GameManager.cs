using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	private static GameManager instance = null;
	public static GameManager Instance {
		get {
			if (instance == null)
			{
				instance = (GameManager)FindObjectOfType(typeof(GameManager));
				if (instance == null)
				{
					Debug.LogError("CREATING A NEW GAME MANAGER -- THIS IS A PROBLEM");
					instance = (new GameObject("GameManager")).AddComponent<GameManager>();
				}
			}
			return instance;
		}
	}


	[SerializeField] protected Material actionModeTintMaterial;

	private bool _actionMode;
	public bool actionMode {
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

	// Use this for initialization
	void Start () {
		
	}

	public bool disableActionMode { get; set; }

	[SerializeField] protected GameObject _wayPointMarker;
	public GameObject wayPointMarker { get { return _wayPointMarker; }  }

	protected void Update () {
		if (!disableActionMode)
			actionMode = Input.GetKey(KeyCode.Space);

	}

}
