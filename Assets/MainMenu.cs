using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Transition transition;

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void PlayQuiz()
    {
        SceneManager.LoadSceneAsync(2);
    }

}
