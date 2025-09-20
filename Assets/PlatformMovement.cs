using UnityEngine;
using System;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 0.5f;
    [SerializeField] private Transform topOfBuilding;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Stop when the top of the is reached
        if (transform.position.y < topOfBuilding.position.y)
        {
            transform.Translate(0, movementSpeed * Time.deltaTime, 0);
        } else {
            // Raise event?
        }
    }
}
