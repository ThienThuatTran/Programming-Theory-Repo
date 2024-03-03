using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenuScene : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public void StartGame()
    {
        GetName();
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        //MainManager.Instance.SaveColor();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();// original code to quit Unity player
#endif
    }
    public void GetName()
    {
        MainManager.Instance.playerName = nameInputField.text;
    }

}
