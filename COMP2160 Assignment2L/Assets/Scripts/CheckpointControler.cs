using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointControler : MonoBehaviour
{
    public Material cpOn;
    public Material cpOff;
    public Renderer theRend;
    public bool checkpointReached;
    // Start is called before the first frame update
    void Start()
    {
        theRend = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            theRend.material = cpOff;
            checkpointReached = true;
        }
    }
}
