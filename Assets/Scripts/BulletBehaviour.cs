using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public float speed = 100f;

	void Update ()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            var mouseToWorld = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 25));
            transform.LookAt(mouseToWorld);
        }

        else if(Input.GetKeyDown(KeyCode.Space))
        {
            
        }
		
	}
}
