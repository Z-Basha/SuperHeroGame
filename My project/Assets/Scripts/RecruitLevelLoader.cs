using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecruitLevelLoader : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene("Recruit");
    }
}
