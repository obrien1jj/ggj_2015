using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	[System.Serializable]
	public class HeroData
	{
		public string name;
		public Material skin;
		public int spriteID;
		  
	}

	public tk2dSprite heroPortrait; 
	public tk2dTextMesh heroNameText;
	public HeroData currHeroData;
	public SkinnedMeshRenderer heroMeshRenderer;

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

	public bool disableActionMode { get; set; }

	[SerializeField] protected GameObject _wayPointMarker;
	public GameObject wayPointMarker { get { return _wayPointMarker; }  }
	public HeroData[] heroes = new HeroData[8];


	void Start()
	{
		//pick a random hero
		Random.seed = System.Environment.TickCount;
		int selectedIndex = Mathf.FloorToInt(Random.value * 8f);
		Debug.Log ("Selected: " + selectedIndex);

		currHeroData = heroes[selectedIndex];

		heroPortrait.SetSprite(currHeroData.spriteID);
		heroNameText.text = currHeroData.name;
		heroMeshRenderer.material = currHeroData.skin;

	}

	protected void Update () {
//		if (!disableActionMode)
//			actionMode = Input.GetKey(KeyCode.Space);


	}

}
