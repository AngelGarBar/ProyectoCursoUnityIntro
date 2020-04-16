using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int numMonedas;
	private int numTotalMonedas;

	private float timeElapsed;
	private float totalTime;
	// Use this for initialization
	void Start () {
		numMonedas = 0;
		numTotalMonedas = 5;
		timeElapsed = 0.0f;
		totalTime = 60.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timeElapsed += Time.deltaTime;
	}

	void OnGUI()
	{
		//Coloca una UI primitiva que lleva la cuenta de monedas y avisas al jugador si ha ganado o ha perdido por el tiempo
		if (timeElapsed >= totalTime)
		{
			GUI.Label(new Rect(10, 10, 150, 100), "HAS PERDIDO");
		}
		else
		{
			if (numMonedas < numTotalMonedas)
			{
				GUI.Label(new Rect(10, 10, 150, 100), "Coins: " + numMonedas + "/" + numTotalMonedas);
				GUI.Label(new Rect(10, 30, 150, 100), "Tiempo: "+(int)(totalTime-timeElapsed));
			}
			else
			{
				GUI.Label(new Rect(10, 10, 150, 100), "HAS GANADO");
			}
		}
		
	}
}
