using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereShape : BasicShape // INHERITANCE
{
    public override void SetData() // POLYMORPHISM
    {
        typeOfShape = "Sphere";
        colorOfShape = "Green";
        sizeOfShape = "3x";
    }

}
