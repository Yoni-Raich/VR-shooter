using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate : MonoBehaviour {

    public GameObject getDup;

    Vector3 positions = new Vector3(0, 0, 0);
    public float timer;
    float x,z;
    int NumOfDu = 0;
    public float posiCount;

    List<GameObject> listDuplicate = new List<GameObject>();
    System.Random rand = new System.Random();
    


    // Update is called once per frame
    void FixedUpdate()
    {
       
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            DupPositoin();
            Duplicating();
            timer += 3;
        }
    }
    //Duplicating the sphere
    public void Duplicating()
    {
        listDuplicate.Add(Instantiate(getDup));
        positions.x = x * 20;
        positions.z = z * 20;
        positions.y = getDup.transform.position.y;
        listDuplicate[NumOfDu].transform.position = positions;
        NumOfDu++;
    }
    // create a random x/z vlaue in a circal
    public void DupPositoin()
    {
        posiCount = rand.Next(10000);

        x = Mathf.Sin(posiCount);
        z = Mathf.Cos(posiCount);

        

        
    }
}
