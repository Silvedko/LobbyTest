using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : Photon.PunBehaviour
{

	// Use this for initialization
	void Start ()
    {
		

		if (photonView.isMine)
			GetComponent <Renderer> ().material.color = Color.red;
		else
			GetComponent <Renderer> ().material.color = Color.blue;
	}  
}
