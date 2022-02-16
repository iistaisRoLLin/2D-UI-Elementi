using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana : MonoBehaviour {

	public GameObject bins;
	public GameObject Lacis;
	public GameObject Tante;
	public GameObject Masina;

	public void binaAttelosana(bool vertiba){
		bins.SetActive (vertiba);
	}
	public void lacisAttelosana(bool vertiba){
		Lacis.SetActive (vertiba);
	}
	public void tanteAttelosana(bool vertiba){
		Tante.SetActive (vertiba);
	}
	public void masinaAttelosana(bool vertiba){
		Masina.SetActive (vertiba);
	}

	public void paKreisiBins(){
		bins.transform.localScale = new Vector2 (1, 1);
	}
	public void paLabiBins(){
		bins.transform.localScale = new Vector2 (-1,1);
	}
}
