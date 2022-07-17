using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenusScript : MonoBehaviour
{
    public GameObject TrainingMenu;

    public void SetActiveUI()
    {
        TrainingMenu.SetActive(true);
    }
    

    // Start is called before the first frame update
    void Start()
    {
        SetActiveUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
