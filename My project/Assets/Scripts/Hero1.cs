using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero1 : HeroesAttributes
{
    // Start is called before the first frame update
    void Start()
    {
        Attack();
    }

   void OnCollisionEnter(Collision collision){
    if (collision.gameObject.tag == "Spawner"){
        Debug.Log("Spawn Enemy");
        gameObject.tag = "InCombat";
    }
   }
   
   
   
    // Update is called once per frame
    // void Update()
    // {

    // }
}
