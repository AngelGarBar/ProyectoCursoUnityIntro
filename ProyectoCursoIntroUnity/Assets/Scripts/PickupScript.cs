using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour {


	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit(Collider col)
	{
		//Cambia las camaras cuando el jugador sale de la zona
		if (col.tag == "Player")
		{
			this.gameObject.SetActive(false);
			col.gameObject.GetComponent<Player>().numMonedas++;
		}
	}
}
