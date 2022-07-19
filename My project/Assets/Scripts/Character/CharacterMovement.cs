using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    float speed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && gameObject.tag != "InCombat") {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
            
        if (Input.GetKey(KeyCode.A) && gameObject.tag != "InCombat"){
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
