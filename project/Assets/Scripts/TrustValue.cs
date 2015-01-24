using UnityEngine;
using System.Collections;

public class TrustValue : MonoBehaviour {

	public int Trust = 20;
	int startTrust;

	// Use this for initialization
	void Start () {
		startTrust = Trust;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeTrust (int dTrustVal) {
		Trust += dTrustVal;
	}
}
