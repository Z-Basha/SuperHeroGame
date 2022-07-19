using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroesAttributes : MonoBehaviour
{
    int Hp = 10;
    int Stamina = 1;
    int Speed = 1;
    int Strength = 1;
    int intelligence = 1;

    public void Attack(){
        Debug.Log("Attack = "+ Strength);
    }

}
