using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectResolution : MonoBehaviour {

	public GameObject noipad;
	public GameObject isiPad;

	void Awake(){
		if ((Screen.width == 1536) && (Screen.height == 2048) || (Screen.width == 2048) && (Screen.height == 2732) || (Screen.width == 768) && (Screen.height == 1024) || (Screen.width == 1024) && (Screen.height == 1366)) {
			Debug.Log ("ES IPAD");
			isiPad.SetActive (true);
			noipad.SetActive (false);
		} else {
			Debug.Log ("no es iPad");
			isiPad.SetActive (false);
			noipad.SetActive (true);
		}
	}


}
