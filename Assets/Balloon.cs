using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : Ball
{
    // Start is called before the first frame update
    protected override void Start()
    {
        bounce = 0.99f;
        force = 15;
        base.Start();
    }

    protected override void OnMouseUp()
    {
        Debug.Log($"{ballName}: Balloon popped!");
        gameObject.GetComponent<AudioSource>().Play();
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
