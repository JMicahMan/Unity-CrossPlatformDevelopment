using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        
        transform.position = new Vector3(PlayerInput.Move.x, PlayerInput.Move.y, 0);


	}
}
