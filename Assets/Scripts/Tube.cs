using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Tube : MonoBehaviour
{
    [SerializeField] Transform _transform;
    [SerializeField] GameObject thisTube;
    float speed = 1.5f;
    private void Start()
    {
        Locator.Instance.Player.TubeCollided += HandlePlayerCollision;
    }
    void Update()
    {
        _transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void HandlePlayerCollision()
    {
        Destroy(thisTube);
    }
}
