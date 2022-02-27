using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StickBehavior : MonoBehaviour
{
    //[Serialize]
    public TextMeshPro debug;
    public Material KeyPressColor;
    public Material OriginalColorReg;
    public Material OriginalColorSharp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision){
        debug.text+="\ncollided";
        if(collision.gameObject.CompareTag("Drum")){
            //debug.text+="\nfound drum";
            collision.gameObject.GetComponent<AudioSource>().Play();
        }
        else if(collision.gameObject.CompareTag("Piano")){
            //debug.text+="\nfound drum";
            OriginalColorReg = collision.gameObject.GetComponent<Renderer>().material;
            collision.gameObject.GetComponent<Renderer>().material = KeyPressColor;
            collision.gameObject.GetComponent<AudioSource>().Play();

        }
        else if(collision.gameObject.CompareTag("PianoSharp")){
            //debug.text+="\nfound drum";
            OriginalColorSharp = collision.gameObject.GetComponent<Renderer>().material;
            collision.gameObject.GetComponent<Renderer>().material = KeyPressColor;
            collision.gameObject.GetComponent<AudioSource>().Play();

        }
    }

    void OnTriggerExit(Collider collision){
        if(collision.gameObject.CompareTag("Piano")){
            //debug.text+="\nfound drum";
            //transform.GetComponent<Renderer>().material = WhiteKeyColor;
            collision.gameObject.GetComponent<Renderer>().material = OriginalColorReg;

            //collision.gameObject.GetComponent<AudioSource>().Play();

        }
        else if(collision.gameObject.CompareTag("PianoSharp")){
            //debug.text+="\nfound drum";
            //transform.GetComponent<Renderer>().material = WhiteKeyColor;
            collision.gameObject.GetComponent<Renderer>().material = OriginalColorSharp;

            //collision.gameObject.GetComponent<AudioSource>().Play();

        }
    }
}
