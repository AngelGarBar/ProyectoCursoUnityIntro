using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteCamara : MonoBehaviour {

	public GameObject mainCamera;
	public GameObject limCamera;

	
	void Start()
	{
		limCamera.SetActive(false);
	}

	void OnTriggerEnter(Collider col)
	{
		//Cuando el jugador entra en la zona cambia la camara
		if(col.tag == "Player")
		{
			mainCamera.SetActive(false);
			limCamera.SetActive(true);
		}
	}

	void OnTriggerExit(Collider col)
	{
		//Cambia las camaras cuando el jugador sale de la zona
		if (col.tag == "Player")
		{
			mainCamera.SetActive(true);
			limCamera.SetActive(false);
		}
	}
}
