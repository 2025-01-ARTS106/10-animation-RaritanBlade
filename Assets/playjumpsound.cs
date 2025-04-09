using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Playjumpsound : MonoBehaviour
{

    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = this.gameObject.GetComponent<AudioSource>();
        if (source == null) Debug.Log("Something isn't right!!!");
    }

    public void playsound()

    {
        if (source == null)
        {
            source.Play();

        }
        else
        {
            Debug.Log("source not set up properly");
        }
    }
}
  