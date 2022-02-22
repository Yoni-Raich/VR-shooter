using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionRotate : MonoBehaviour {

    float timeCount = 0;
	
	// Update is called once per frame
	void Update ()
    {
        timeCount += 10000;

        float x = Mathf.Sin(timeCount);
        float y = 0;
        float z = Mathf.Cos(timeCount);

        transform.position = new Vector3(x*12, y, z*12);

    }
}
