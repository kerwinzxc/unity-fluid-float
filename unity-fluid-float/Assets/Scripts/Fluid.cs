using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fluid : MonoBehaviour {

    void Start () {
		
    }
	
    void Update () {
		
    }

    public void OnTriggerEnter(Collider other) {
       if (other.gameObject.GetComponent<Rigidbody>() == null)
           return;
    }
}
