using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private SphereCollider sphereCollider;
    private Rigidbody rb;

    public string ballName { get; private set; } = "Ball";

    protected float bounce = 0.8f;
    protected int force = 10;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        sphereCollider = gameObject.GetComponent<SphereCollider>();
        rb = gameObject.GetComponent<Rigidbody>();

        sphereCollider.material.bounciness = bounce;
    }

    void Knockup(int force)
    {
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
    }

    protected virtual void OnMouseUp()
    {
        Knockup(force);
    }
}
