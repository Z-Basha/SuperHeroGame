using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickLoader : MonoBehaviour
{
    
    public void LoadTrainingLevel()
    {
        SceneManager.LoadScene("Menus");
    }

}
