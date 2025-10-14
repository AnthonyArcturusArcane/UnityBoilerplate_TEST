using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Main_Menu_Control : MonoBehaviour
    {
        // syntax of functions:
        // ReturnType FunctionName(ParameterType parameterName, ...)  {... function body ... }
        // void means the function does not return any value
        // StartGame is the name of the function
        // () means the function does not take any parameters
        // {...} is the body of the function

        // SceneManager is an API from Unity that allows us to manage scenes
        // LoadScene is a function that loads a scene by its name or index
        // "Game" is the name of the scene we want to load
        public void ChangeScene(string game)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
        }

    }
