using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickLoader : MonoBehaviour
{
    
    public void LoadMenu(int menu)
    {
        MenusScript.SetActiveUI(menu);
        SceneManager.LoadScene("Menus");
    }
    

}