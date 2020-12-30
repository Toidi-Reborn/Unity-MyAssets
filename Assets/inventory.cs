using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class inventory : MonoBehaviour {

    public List<string> myInventory = new List<string>();
    private bool showInv = false;
    
    GameObject window;
    FirstPersonController fpc;



// Need to generate item squars through script.... delete prefab parts
    
    void Start() {
        window = GameObject.Find("iWindow");
        window.SetActive(false);
        

        fpc = GameObject.Find("Player").GetComponent<FirstPersonController>();
         
        myInventory.Add("Flash Light");
        myInventory.Add("Match");
        myInventory.Add("Key 001");
        myInventory.Add("Key 013");
        
    }
    
     
    void Update() {
        if (Input.GetKeyDown(KeyCode.I)) {
            if (showInv){
                hide();
            } else {
                show();
            }
            showInv = !showInv;
        
            Debug.Log(myInventory[0]);
            Debug.Log(myInventory.Count);
            foreach (string x in myInventory){
                Debug.Log(x);

            }          
        }
    }

    void show(){
        window.SetActive(true);
        fpc.enabled = false;
        
    }
    void hide(){
        window.SetActive(false);
        fpc.enabled = true;
    }



}
