using UnityEngine;
using System;

// Script for the camera to follow the player

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = player.transform.position;
        pos.y += 1.5f; // adjust for height of player
        transform.position = pos + new Vector3(0, 0, -10);
    }
}
