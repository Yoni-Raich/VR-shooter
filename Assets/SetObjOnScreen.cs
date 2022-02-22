using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjOnScreen : MonoBehaviour {

    public GameObject gun;
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 centerPos = new Vector3(Screen.width/2,0);
        gun.transform.position = centerPos;

    }
}
