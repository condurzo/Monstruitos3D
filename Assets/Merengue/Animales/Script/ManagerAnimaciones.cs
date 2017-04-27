using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ManagerAnimaciones : MonoBehaviour {



	public static bool Detecto;
	public Button Btn1;
	public Button Btn2;
	public Button Btn3;
	public Button Btn4;

	public GameObject goZombie;
	//public GameObject goMomia;
	public GameObject goEsqueleto;
	public GameObject goVampira;
	public GameObject goBruja;

	public GameObject Zombie;
	public GameObject Zombie_Idle;
	public GameObject Zombie_Walk;
	public GameObject Zombie_Jump;
	public GameObject Zombie_Sleep;

//	public GameObject Momia;
//	public GameObject Momia_Idle;
//	public GameObject Momia_Walk;
//	public GameObject Momia_Jump;
//	public GameObject Momia_Sleep;

	public GameObject Esqueleto;
	public GameObject Esqueleto_Idle;
	public GameObject Esqueleto_Walk;
	public GameObject Esqueleto_Jump;
	public GameObject Esqueleto_Sleep;

	public GameObject Vampira;
	public GameObject Vampira_Idle;
	public GameObject Vampira_Walk;
	public GameObject Vampira_Sleep;
	public GameObject Vampira_Jump;

	public GameObject Bruja;
	public GameObject Bruja_Idle;
	public GameObject Bruja_Walk;
	public GameObject Bruja_Sleep;
	public GameObject Bruja_Jump;

	public Animation idleAnima;

	public string currentAnimation;

	public static bool Caminando;
	public static bool Saltando;
	public bool Salto1;
	public static bool Salto2;
	public bool Salto3;
	public bool SaltandoFinal;
	public float ContadorSalto;
	public float ContadorSaltoDos;

	public AudioSource audios;
	public AudioClip audioWalk;
	public AudioClip audioJump;
	public AudioClip audioDormir;
	public AudioClip Vacio;

	public GameObject SonidoONbtn;
	public GameObject SonidoOFFbtn;
	public AudioSource MusicaFondo;

	public static string QuienEs;

	public bool OneDetect;


	void Start(){
		
		CameraDevice.Instance.SetFocusMode (CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
		audios = GetComponent<AudioSource> ();
		Parado ();
	}

	public void Parado(){
		if((currentAnimation != "Idle")&&(!SaltandoFinal)){
			//ZOMBIE
			Zombie_Idle.SetActive (true);
			Zombie_Walk.SetActive (false);
			Destroy(GameObject.Find("Zombie_Jump(Clone)"));
			Destroy(GameObject.Find("Zombie_Sleep(Clone)"));

			//MOMIA
//			Momia_Idle.SetActive (true);
//			Momia_Walk.SetActive (false);
//			Destroy(GameObject.Find("Momia_Jump(Clone)"));
//			Destroy(GameObject.Find("Momia_Sleep(Clone)"));

			//ESQUELETO
			Esqueleto_Idle.SetActive (true);
			Esqueleto_Walk.SetActive (false);
			Destroy(GameObject.Find("Esqueleto_Jump(Clone)"));
			Destroy(GameObject.Find("Esqueleto_Sleep(Clone)"));

			//VAMPIRA
			Vampira_Idle.SetActive (true);
			Vampira_Walk.SetActive (false);
			Destroy(GameObject.Find("Vampira_Jump(Clone)"));
			Destroy(GameObject.Find("Vampira_Sleep(Clone)"));

			//BRUJA
			Bruja_Idle.SetActive (true);
			Bruja_Walk.SetActive (false);
			Destroy(GameObject.Find("Bruja_Jump(Clone)"));
			Destroy(GameObject.Find("Bruja_Sleep(Clone)"));

			currentAnimation = "Idle";
			audios.clip = Vacio;
			audios.Stop ();
			audios.loop = false;
			Caminando = false;
		}
	}
	public void Caminar(){
		if((currentAnimation != "Walk")&&(!SaltandoFinal)){
			//ZOMBIE
			Zombie_Idle.SetActive (false);
			Zombie_Walk.SetActive (true);
			Destroy(GameObject.Find("Zombie_Jump(Clone)"));
			Destroy(GameObject.Find("Zombie_Sleep(Clone)"));

			//MOMIA
//			Momia_Idle.SetActive (false);
//			Momia_Walk.SetActive (true);
//			Destroy(GameObject.Find("Momia_Jump(Clone)"));
//			Destroy(GameObject.Find("Momia_Sleep(Clone)"));

			//ESQUELETO
			Esqueleto_Idle.SetActive (false);
			Esqueleto_Walk.SetActive (true);
			Destroy(GameObject.Find("Esqueleto_Jump(Clone)"));
			Destroy(GameObject.Find("Esqueleto_Sleep(Clone)"));

			//VAMPIRA
			Vampira_Idle.SetActive (false);
			Vampira_Walk.SetActive (true);
			Destroy(GameObject.Find("Vampira_Jump(Clone)"));
			Destroy(GameObject.Find("Vampira_Sleep(Clone)"));

			//BRUJA
			Bruja_Idle.SetActive (false);
			Bruja_Walk.SetActive (true);
			Destroy(GameObject.Find("Bruja_Jump(Clone)"));
			Destroy(GameObject.Find("Bruja_Sleep(Clone)"));


			currentAnimation = "Walk";
			audios.clip = audioWalk;
			audios.volume = 1.0f;
			audios.Play ();
			audios.loop = true;
			Caminando = true;
		}
	}

	public void Dormir(){
		if((currentAnimation != "Sleep")&&(!SaltandoFinal)){
			//ZOMBIE
			if (QuienEs == "ZombieFinal") {
				Zombie_Idle.SetActive (false);
				Zombie_Walk.SetActive (false);
				Destroy (GameObject.Find ("Zombie_Jump(Clone)"));
				Destroy (GameObject.Find ("Zombie_Sleep(Clone)"));
				goZombie = Instantiate (Zombie_Sleep, new Vector3 (31.1f, 0, -15), Quaternion.identity) as GameObject; 
				goZombie.transform.parent = GameObject.Find ("m_Zombie").transform;
				goZombie.transform.localScale = new Vector3 (1, 1, 1);
				goZombie.transform.rotation = Quaternion.Euler (0, 180, 0);
			}

			//MOMIA
//			if (QuienEs == "Perro") {
//				Momia_Idle.SetActive (false);
//				Momia_Walk.SetActive (false);
//				Destroy (GameObject.Find ("Momia_Jump(Clone)"));
//				Destroy (GameObject.Find ("Momia_Sleep(Clone)"));
//				goMomia = Instantiate (Momia_Sleep, new Vector3 (31.1f, 0, -15), Quaternion.identity) as GameObject; 
//				goMomia.transform.parent = GameObject.Find ("m_Mummy").transform;
//				goMomia.transform.localScale = new Vector3 (1, 1, 1);
//				goMomia.transform.rotation = Quaternion.Euler (0, 180, 0);
//			}

			//ESQUELETO
			if (QuienEs == "MomiaFinal") {
				Esqueleto_Idle.SetActive (false);
				Esqueleto_Walk.SetActive (false);
				Destroy (GameObject.Find ("Esqueleto_Jump(Clone)"));
				Destroy (GameObject.Find ("Esqueleto_Sleep(Clone)"));
				goEsqueleto = Instantiate (Esqueleto_Sleep, new Vector3 (31.1f, 0, -15), Quaternion.identity) as GameObject; 
				goEsqueleto.transform.parent = GameObject.Find ("m_Bones").transform;
				goEsqueleto.transform.localScale = new Vector3 (1, 1, 1);
				goEsqueleto.transform.rotation = Quaternion.Euler (0, 180, 0);
			}

			//VAMPIRA
			if (QuienEs == "VampiraFinal") {
				Vampira_Idle.SetActive (false);
				Vampira_Walk.SetActive (false);
				Destroy (GameObject.Find ("Vampira_Jump(Clone)"));
				Destroy (GameObject.Find ("Vampira_Sleep(Clone)"));
				goVampira = Instantiate (Vampira_Sleep, new Vector3 (31.1f, 0, -15), Quaternion.identity) as GameObject; 
				goVampira.transform.parent = GameObject.Find ("f_Vampirette").transform;
				goVampira.transform.localScale = new Vector3 (1, 1, 1);
				goVampira.transform.rotation = Quaternion.Euler (0, 180, 0);
			}

			//BRUJA
			if (QuienEs == "BrujaFinal") {
				Bruja_Idle.SetActive (false);
				Bruja_Walk.SetActive (false);
				Destroy (GameObject.Find ("Bruja_Jump(Clone)"));
				Destroy (GameObject.Find ("Bruja_Sleep(Clone)"));
				goBruja = Instantiate (Bruja_Sleep, new Vector3 (31.1f, 0, -15), Quaternion.identity) as GameObject; 
				goBruja.transform.parent = GameObject.Find ("f_Witch").transform;
				goBruja.transform.localScale = new Vector3 (1, 1, 1);
				goBruja.transform.rotation = Quaternion.Euler (0, 180, 0);
			}


			currentAnimation = "Sleep";

			audios.clip = audioDormir;
			audios.volume = 1.0f;
			audios.Play ();
			audios.loop = true;
			Caminando = false;

		}
	}

	public void Saltar(){
		if(!Saltando){
			Saltando = true;
			Salto1 = true;
			SaltandoFinal = true;

			//ZOMBIE
			if (QuienEs == "ZombieFinal") {
				Zombie_Idle.SetActive (false);
				Zombie_Walk.SetActive (false);
				Destroy (GameObject.Find ("Zombie_Jump(Clone)"));
				Destroy (GameObject.Find ("Zombie_Sleep(Clone)"));
				goZombie = Instantiate (Zombie_Jump, new Vector3 (31.1f, 0, -15), Quaternion.identity) as GameObject; 
				goZombie.transform.parent = GameObject.Find ("m_Zombie").transform;
				goZombie.transform.localScale = new Vector3 (1, 1, 1);
				goZombie.transform.rotation = Quaternion.Euler (0, 180, 0);
			}

			//MOMIA
//			if (QuienEs == "Perro") {
//				Momia_Idle.SetActive (false);
//				Momia_Walk.SetActive (false);
//				Destroy (GameObject.Find ("Momia_Jump(Clone)"));
//				Destroy (GameObject.Find ("Momia_Sleep(Clone)"));
//				goMomia = Instantiate (Momia_Jump, new Vector3 (31.1f, 0, -15), Quaternion.identity) as GameObject; 
//				goMomia.transform.parent = GameObject.Find ("m_Mummy").transform;
//				goMomia.transform.localScale = new Vector3 (1, 1, 1);
//				goMomia.transform.rotation = Quaternion.Euler (0, 180, 0);
//			}

			//ESQUELETO
			if (QuienEs == "MomiaFinal") {
				Esqueleto_Idle.SetActive (false);
				Esqueleto_Walk.SetActive (false);
				Destroy (GameObject.Find ("Esqueleto_Jump(Clone)"));
				Destroy (GameObject.Find ("Esqueleto_Sleep(Clone)"));
				goEsqueleto = Instantiate (Esqueleto_Jump, new Vector3 (31.1f, 0, -15), Quaternion.identity) as GameObject; 
				goEsqueleto.transform.parent = GameObject.Find ("m_Bones").transform;
				goEsqueleto.transform.localScale = new Vector3 (1, 1, 1);
				goEsqueleto.transform.rotation = Quaternion.Euler (0, 180, 0);
			}

			//VAMPIRA
			if (QuienEs == "VampiraFinal") {
				Vampira_Idle.SetActive (false);
				Vampira_Walk.SetActive (false);
				Destroy (GameObject.Find ("Vampira_Jump(Clone)"));
				Destroy (GameObject.Find ("Vampira_Sleep(Clone)"));
				goVampira = Instantiate (Vampira_Jump, new Vector3 (31.1f, 0, -15), Quaternion.identity) as GameObject; 
				goVampira.transform.parent = GameObject.Find ("f_Vampirette").transform;
				goVampira.transform.localScale = new Vector3 (1, 1, 1);
				goVampira.transform.rotation = Quaternion.Euler (0, 180, 0);
			}

			//BRUJA
			if (QuienEs == "BrujaFinal") {
				Bruja_Idle.SetActive (false);
				Bruja_Walk.SetActive (false);
				Destroy (GameObject.Find ("Bruja_Jump(Clone)"));
				Destroy (GameObject.Find ("Bruja_Sleep(Clone)"));
				goBruja = Instantiate (Bruja_Jump, new Vector3 (31.1f, 0, -15), Quaternion.identity) as GameObject; 
				goBruja.transform.parent = GameObject.Find ("f_Witch").transform;
				goBruja.transform.localScale = new Vector3 (1, 1, 1);
				goBruja.transform.rotation = Quaternion.Euler (0, 180, 0);
			}

			currentAnimation = "Sleep";

			audios.clip = audioJump;
			audios.volume = 1.0f;
			audios.Play ();
			audios.loop = false;
			Debug.Log ("ASD");
			currentAnimation = "Jump";
		}
	}


	void Update(){

		if (Salto1) {
			ContadorSalto += Time.deltaTime;
		}
		if (ContadorSalto >= 1.3f) {
			Salto1 = false;
			ContadorSalto = 0;
			currentAnimation = "noJump";
			SaltandoFinal = false;
			Saltando = false;
		}

		if (Detecto) {
			if (!OneDetect) {
				Parado ();
				OneDetect = true;
			}

			Btn1.interactable = true;
			Btn2.interactable = true;
			Btn3.interactable = true;
			Btn4.interactable = true;
//			if (!audios.isPlaying) {
//				if (currentAnimation != "Jump") {
//					audios.Play ();
//					audios.loop = true;
//				} else {
//					audios.clip = Vacio;
//					audios.Stop ();
//					audios.loop = false;
//				}
//			}
		} else {
			OneDetect = false;
			Btn1.interactable = false;
			Btn2.interactable = false;
			Btn3.interactable = false;
			Btn4.interactable = false;
			audios.Stop ();
			audios.loop = false;
		}
	}
	public void SonidoON(){
		//SonidoONbtn.SetActive (false);
		//SonidoOFFbtn.SetActive (true);
		MusicaFondo.Play ();
	}

	public void SonidoOFF(){
		//SonidoONbtn.SetActive (true);
		//SonidoOFFbtn.SetActive (false);
		MusicaFondo.Pause ();
	}

	public void GoToMenu(){
		Application.LoadLevel ("MenuMO");
	}
	public void ExitBtn(){
		Application.Quit ();
	}
}
