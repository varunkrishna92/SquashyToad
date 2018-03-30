using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LethalComponent : MonoBehaviour {
    public Death deathComponent;
	// Use this for initialization
	void Start () {
        deathComponent = FindObjectOfType<Death>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        deathComponent.OnDeath();
    }
}
