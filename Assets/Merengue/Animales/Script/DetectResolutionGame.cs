using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectResolutionGame : MonoBehaviour {

	public GameObject SounOffiPad;
	public GameObject ExitiPad;

	public GameObject SounOff;
	public GameObject Exiti;

	public GameObject Bt1No;
	public GameObject Bt2No;
	public GameObject Bt3No;
	public GameObject Bt4No;

	public GameObject Btn1iPad;
	public GameObject Btn2iPad;
	public GameObject Btn3iPad;
	public GameObject Btn4iPad;

	void Awake(){
		if ((Screen.width == 1536) && (Screen.height == 2048) || (Screen.width == 2048) && (Screen.height == 2732) || (Screen.width == 768) && (Screen.height == 1024) || (Screen.width == 1024) && (Screen.height == 1366)) {
			Debug.Log ("ES IPAD");
			SounOffiPad.SetActive (true);
			ExitiPad.SetActive (true);

			SounOff.SetActive (false);
			Exiti.SetActive (false);

			Bt1No.SetActive (false);
			Bt2No.SetActive (false);
			Bt3No.SetActive (false);
			Bt4No.SetActive (false);

			Btn1iPad.SetActive (true);
			Btn2iPad.SetActive (true);
			Btn3iPad.SetActive (true);
			Btn4iPad.SetActive (true);

		} else {
			Debug.Log ("no es iPad");
			SounOffiPad.SetActive (false);
			ExitiPad.SetActive (false);

			SounOff.SetActive (true);
			Exiti.SetActive (true);

			Bt1No.SetActive (true);
			Bt2No.SetActive (true);
			Bt3No.SetActive (true);
			Bt4No.SetActive (true);

			Btn1iPad.SetActive (false);
			Btn2iPad.SetActive (false);
			Btn3iPad.SetActive (false);
			Btn4iPad.SetActive (false);
		}
	}


}
