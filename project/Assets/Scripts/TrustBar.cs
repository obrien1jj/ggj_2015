using UnityEngine;
using System.Collections;

public class TrustBar : MonoBehaviour
{
	private static TrustBar instance = null;
	public static TrustBar Instance {
		get {
			if (instance == null)
			{
				instance = (TrustBar)FindObjectOfType(typeof(TrustBar));
				if (instance == null)
				{
					Debug.LogError("CREATING A NEW TRUST BAR -- THIS IS A PROBLEM");
					instance = (new GameObject("GameManager")).AddComponent<TrustBar>();
				}
			}
			return instance;
		}
	}
	public tk2dClippedSprite clippedSpriteBar; 
	
	private float Value = 1;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	public void updateBar(float trust)
	{
		Value = trust;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Application.isPlaying) {
			clippedSpriteBar.clipTopRight = new Vector2(Value, 1);
		}
	}
}

