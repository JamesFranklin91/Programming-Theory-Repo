using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBall : Ball
{
    protected override void Start()
    {
        bounce = 0.8f;
        force = 10;
        base.Start();
    }

    protected override void OnMouseUp()
    {
        Debug.Log($"{ballName}: Light ball bounce");
        base.OnMouseUp();
    }
}
