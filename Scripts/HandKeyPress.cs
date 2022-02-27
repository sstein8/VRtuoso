using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandKeyPress : MonoBehaviour
{
    public TextMeshPro debug;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        debug.text+="\ncollided";
        if(collision.gameObject.CompareTag("Piano")){
            debug.text+="\nfound piano";
            collision.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}

