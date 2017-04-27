using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMenu : MonoBehaviour {


	public void GoToHome () {
		Application.LoadLevel ("HomeMo");
	}
	public void ExitApp(){
		Application.Quit ();
	}
}
