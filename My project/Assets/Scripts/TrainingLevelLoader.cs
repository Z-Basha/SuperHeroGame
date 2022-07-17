using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrainingLevelLoader : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene("Training");
    }
}