﻿using UnityEngine;
using System.Collections;

public class Airplane : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	
	}

	void OnTriggerEnter(Collider other) {

        // trigger helicopter's explode function via HeliController component
        // and then destroy this airplane as well
        if (other.gameObject.tag == "Shot")
        {
            Destroy(other.gameObject);
        }
        else
        {
            other.transform.parent.GetComponent<HeliController>().Explode();
        }
        Destroy(gameObject);
	}
}
