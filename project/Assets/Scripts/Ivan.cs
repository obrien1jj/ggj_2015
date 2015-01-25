using UnityEngine;
using System.Collections;

public class Ivan : MonoBehaviour {
	private static Ivan instance = null;
	public static Ivan Instance {
		get {
			if (instance == null)
			{
				instance = (Ivan)FindObjectOfType(typeof(Ivan));
				if (instance == null)
				{
					Debug.LogError("CREATING A NEW Ivan -- THIS IS A PROBLEM");
					instance = (new GameObject("Ivan")).AddComponent<Ivan>();
				}
			}
			return instance;
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
