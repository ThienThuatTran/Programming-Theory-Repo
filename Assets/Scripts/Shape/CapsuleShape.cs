using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleShape : BasicShape // INHERITANCE
{
    
    public override void SetData() // POLYMORPHISM
    {
        typeOfShape = "Capsule";
        colorOfShape = "Blue";
        sizeOfShape = "2.5x";
    }
}
