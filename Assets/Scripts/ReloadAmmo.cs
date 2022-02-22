using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadAmmo : MonoBehaviour {
    public AudioSource AudioReload;

    public void NewAmmo()
    {


       AudioReload.Play();

       FindObjectOfType<Shooting>().Reload();
       FindObjectOfType<Shooting>().SetAmmo();
    
    }
}
