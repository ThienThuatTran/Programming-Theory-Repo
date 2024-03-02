using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderShape : BasicShape // INHERITANCE
{
    public override void SetData() // POLYMORPHISM
    {
        typeOfShape = "Cylinder";
        colorOfShape = "Yellow";
        sizeOfShape = "3x";
    }
}
