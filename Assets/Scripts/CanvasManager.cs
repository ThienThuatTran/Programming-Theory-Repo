using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI helloText;

    public void ReturnMenu() //Abstraction
    {
        SceneManager.LoadScene(0);
    }

    private void Awake()
    {

        if (MainManager.Instance.playerName != "")
        {
            helloText.text = "Hi " + MainManager.Instance.playerName + "!";
        }
        else
        {
            helloText.text = "Hi!";
        }
    }
}
