using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour {

    
    float CamRotat;
    public GameObject canera; 
    public Image ball_1, ball_2, ball_3, ball_4, ball_5, ball_6;
    public List<Image> Balls = new List<Image>();



    public void Start()
    {
        Reload();
    }

    public void BallLess()
    {
        if(Balls.Count > 0)
        {
            Balls[Balls.Count-1].enabled = false;
            Balls.RemoveAt(Balls.Count-1);
            Debug.Log(Balls.Count);
           
        }
    }
    public void Reload()
    {
        Balls.Clear();
        
        Balls.Add(ball_1);
        Balls.Add(ball_2);
        Balls.Add(ball_3);
        Balls.Add(ball_4);
        Balls.Add(ball_5);
        Balls.Add(ball_6);

        Balls[0].enabled = true;
        Balls[1].enabled = true;
        Balls[2].enabled = true;
        Balls[3].enabled = true;
        Balls[4].enabled = true;
        Balls[5].enabled = true;

        
    }
    public void SetAmmo()
    {
       
       
            
        
    }
}
