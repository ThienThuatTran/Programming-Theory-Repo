using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using TMPro;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;

public class BasicShape : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI shapeTypeText;// ENCAPSULATION
    [SerializeField] private TextMeshProUGUI colorText;
    [SerializeField] private TextMeshProUGUI sizeText;


    public string typeOfShape { get; protected set; }// ENCAPSULATION
    public string colorOfShape { get; protected set; }
    public string sizeOfShape { get; protected set; }
    public virtual void SetData() // ABSTRACTION
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

    public void DisplayText() // ABSTRACTION
    {
        shapeTypeText.text = "Shape Type: " + typeOfShape;
        colorText.text = "Color: " + colorOfShape;
        sizeText.text = "Size: " + sizeOfShape;
    }

}
