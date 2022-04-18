using System;
using UnityEngine;

public class CubeCameraScript : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        transform.position = player.position + offset;
    }
}
