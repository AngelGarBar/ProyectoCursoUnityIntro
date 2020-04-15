using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public GameObject personaje;
	public float posX;
	public float posY;
	public float posZ;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update()
	{
		this.gameObject.transform.position = new Vector3(personaje.transform.position.x + posX, personaje.transform.position.y + posY, personaje.transform.position.z+posZ);
	}
}
