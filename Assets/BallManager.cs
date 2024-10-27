using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    GameObject[] balls;

    private void Start()
    {
        balls = GameObject.FindGameObjectsWithTag("ball");
    }

    public void BounceBalls()
    {
        foreach (GameObject ball in balls)
        {

        }
    }
}
