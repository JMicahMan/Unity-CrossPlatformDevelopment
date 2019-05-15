using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentBehaviour : MonoBehaviour
{

	void Update ()
    {

      var mouseToWorld = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 25));
        transform.LookAt(mouseToWorld);
		
	}
}
