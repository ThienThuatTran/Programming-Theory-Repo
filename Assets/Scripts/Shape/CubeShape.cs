using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShape : BasicShape // INHERITANCE
{
    public override void SetData() // POLYMORPHISM
    {
        typeOfShape = "Cube";
        colorOfShape = "Red";
        sizeOfShape = "2x";
    }

}
