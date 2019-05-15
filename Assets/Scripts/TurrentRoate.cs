using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TurrentRoate
{
    public static Vector2 Aim
    {
        get
        {
            return new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        }
    }
}
