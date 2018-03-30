using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
    public GameObject canvasObject;
    public GameObject reticule;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDeath()
    {
        canvasObject.SetActive(true);
        reticule.SetActive(true);
        GetComponent<Rigidbody>().isKinematic = true;

    }
}
