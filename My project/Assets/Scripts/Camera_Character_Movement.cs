using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Character_Movement : MonoBehaviour
{
    float speed = 150;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && gameObject.tag != "InCombat"){
            transform.position += transform.right * speed * Time.deltaTime;}
        if (Input.GetKey(KeyCode.A) && gameObject.tag != "InCombat"){
            transform.position += transform.right * -speed * Time.deltaTime;}
}
}
