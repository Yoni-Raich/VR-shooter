using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hit : MonoBehaviour {

    public RawImage live1, live2, live3;
    List<RawImage> ListLives = new List<RawImage>();

    public GameObject FX;

    int LiveLeft = 3;

    private void Start()
    {
        ListLives.Add(live1);
        ListLives.Add(live2);
        ListLives.Add(live3);
    }
    

    void OnCollisionEnter(Collision cInfo)
    {
        if (cInfo.collider.tag == "target")
        {
            if(LiveLeft > 1)
            {
                LiveLeft--;

                ListLives[LiveLeft].enabled = false;
            }else
            {
                SceneManager.LoadScene("GameOver");
            }
            Destroy(cInfo.gameObject);
            Destroy(Instantiate(FX, transform.position, Quaternion.identity), 3);
        }
    }
}
