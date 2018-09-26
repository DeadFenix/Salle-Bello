using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJugador : MonoBehaviour {
	float velocidad = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
		}
		else if  (Input.GetKey(KeyCode.S))
        {
			transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }
		else if (Input.GetKey(KeyCode.A))
        {
			transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
		else if (Input.GetKey(KeyCode.D))
        {
			transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
	}
}
