using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnSticks : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform LStickSpawnPoint;
    public Transform RStickSpawnPoint;
    public GameObject LStick;
    public GameObject RStick;
    
    public Text debug;
    //bool isPressed = false;
    void Start(){

    }
    void Update(){
        
    }

    void OnTriggerEnter(Collider collision)
    {
        //OVRInput.Update();
        if(collision.gameObject.CompareTag("TriggerWall")){
            debug.text+="\nfound wall";
            Instantiate(LStick, LStickSpawnPoint.position, LStickSpawnPoint.rotation);
            Instantiate(RStick, RStickSpawnPoint.position, RStickSpawnPoint.rotation);
           // collision.gameObject.GetComponent<AudioSource>().Play();
        }
        // debug.text+="\nhavent pressed yet";
        
        // if(OVRInput.GetDown(OVRInput.Button.One)){
       
        //     //spawn the sticks
        //     //print(isPressed);
        //     debug.text+="\nbutton a is being pressed";
            
        //     Instantiate(LStick, LStickSpawnPoint.position, LStickSpawnPoint.rotation);
        //     Instantiate(RStick, RStickSpawnPoint.position, RStickSpawnPoint.rotation);

        // }

    }
}

  
