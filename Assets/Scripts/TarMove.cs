using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarMove : MonoBehaviour {

    
    public Rigidbody rg;

    public GameObject FX;

    public AudioSource shooting;

    public Transform target;
    float distanceToStop = 1;
    public float speed = 10;


    Vector3 movingRg = new Vector3(0, 0, 0);

    float movX,movZ;
    float a, r;

    public float Mspeed = 1;
    public float forceSpeed;

    float live = 1;



    // Update is called once per frame
    void FixedUpdate ()
    {
        MovmentControl();
        
    



    }

    public void Start()
    {
        
    }
    //  #checking position by x,z to move into the 0
    public void MovmentControl()
    {
        //if (Vector3.Distance(transform.position, gameObject.transform.position) > distanceToStop)
      //  {
            transform.LookAt(target);
            rg.AddRelativeForce(Vector3.forward * speed, ForceMode.Force);
            Debug.Log("movmet are work");
       // }


    }

    public void Push()
    {
        Destroy(gameObject);
        Destroy(Instantiate(FX, transform.position, Quaternion.identity), 3);

    }
    public void Shoot()
    {
        if (FindObjectOfType<Shooting>().Balls.Count > 0)
        {

            if (live == 0)
            {
                Push();
                
            }
            else
            {
                live--;
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                rg.AddForce(0, 200, 0);
                transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            }
            FindObjectOfType<PlayAudio>().playAudioShoot();
            FindObjectOfType<Shooting>().BallLess();
        }
        else
        {
            FindObjectOfType<PlayAudio>().Empty();
        }
    }


}
