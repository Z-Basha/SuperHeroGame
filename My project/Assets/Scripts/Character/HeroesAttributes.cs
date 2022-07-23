using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroesAttributes : MonoBehaviour
{
    static int MAX_ABILITIES = 3;
    int hp = 10;
    int stamina = 1;
    int speed = 1;
    int strength = 1;
    int intelligence = 1;

    public GameObject[] abilities = new GameObject[MAX_ABILITIES];



    public void Attack(){
        Debug.Log("Attack = "+ strength);
    }

    public void CheckOnClick() {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                // if hit any button then just do nothing
                foreach (GameObject g in abilities) 
                    if (hit.transform.name == g.name) 
                        return;
                // if hero & button is not clicked
                if (hit.transform.name != this.name) {
                    foreach (GameObject g in abilities) 
                        g.SetActive(false);
                    return;
                }
                // if hero is clicked
                foreach (GameObject g in abilities)
                    g.SetActive(true);
            }
        }
    }



}
