using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class LightBall : Ball
{
    protected override void Start()
    {
        bounce = 0.8f;
        force = 10;
        base.Start();
    }

    // POLYMORPHISM
    protected override void OnMouseUp()
    {
        Debug.Log($"{ballName}: Light ball bounce");
        base.OnMouseUp();
    }
}
