using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentBehaviour : MonoBehaviour {


    public GameObject GObj;

    public Transform GTran;

    public Vector3 Velocity;

	// Use this for initialization
	void Start ()
    {

        Velocity = Vector3.up;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.GetComponent<AgentBehaviour>();
	}
}
