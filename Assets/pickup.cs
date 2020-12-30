﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    [SerializeField] public bool opened = false;
    [SerializeField] public bool canPickUp = true;
    [SerializeField] public bool interactable = true;
    [SerializeField] public bool locked = false;
    [SerializeField] public string item = "Coin";


    inventory myINV;
    

    public bool lookedAt = false;

       
     

    void Start()
    {
        myINV = GameObject.Find("game").GetComponent<inventory>();

    }
 


    void Update()
    {
        transform.Rotate(0,2.5f,0 * Time.deltaTime);
        
        if (lookedAt){
                listenForKey();          
        }
        lookedAt = false;     


    }


    void listenForKey(){
        if (Input.GetKeyDown(KeyCode.K)) {
                keyXPressed();
        }
    
    }


    void keyXPressed(){
        myINV.myInventory.Add(this.item);
        Destroy(gameObject);

    }


}
