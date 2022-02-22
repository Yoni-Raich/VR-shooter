using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {

    public AudioSource shooting;
    public AudioSource empty;
    public void playAudioShoot()
    {
        shooting.Play();       
    }
    public void Empty()
    {
        empty.Play();
    }
}
