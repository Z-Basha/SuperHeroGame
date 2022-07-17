using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenusScript : MonoBehaviour
{
    static int ACTIVE_UI = 0;
    static int TOTAL_MENU = 4;
    
    public GameObject[] UIMenu = new GameObject[TOTAL_MENU];
    public static void SetActiveUI(int UIIdx)
    {   
        ACTIVE_UI = UIIdx;
    }
    
    public void showUI (int UIIdx)
    {
        UIMenu[UIIdx].SetActive(true);
    }

    void Start()
    {
        this.showUI(MenusScript.ACTIVE_UI);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("HQ");
        }
    }
}
