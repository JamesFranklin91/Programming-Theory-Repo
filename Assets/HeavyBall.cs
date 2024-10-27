using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyBall : Ball
{
    // Start is called before the first frame update
    protected override void Start()
    {
        bounce = 0.2f;
        force = 5;
        base.Start();
    }

    protected override void OnMouseUp()
    {
        Debug.Log($"{ballName}: Heavy ball bounce");
        base.OnMouseUp();
    }
}
