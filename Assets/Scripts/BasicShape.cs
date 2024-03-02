using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using TMPro;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;

public class BasicShape : MonoBehaviour
{
    public TextMeshProUGUI shapeTypeText;
    public TextMeshProUGUI colorText;
    public TextMeshProUGUI sizeText;

    public string typeOfShape;
    public string colorOfShape;
    public string sizeOfShape;
    public virtual void SetData()
    {
        typeOfShape = "???";
        colorOfShape = "???";
        sizeOfShape = "???";
    }
    
    private void OnMouseDown()
    {
        SetData();
        DisplayText();
    }

    public void DisplayText()
    {
        shapeTypeText.text = "Shape Type: " + typeOfShape;
        colorText.text = "Color: " + colorOfShape;
        sizeText.text = "Size: " + sizeOfShape;
    }

}
