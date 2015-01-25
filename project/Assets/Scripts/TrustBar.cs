using UnityEngine;
using System.Collections;

public class TrustBar : MonoBehaviour
{
	public tk2dClippedSprite clippedSpriteBar; 
	
	private float Value = .5f;
	
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

