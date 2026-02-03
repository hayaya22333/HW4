using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TubeSpawner : MonoBehaviour
{
    [SerializeField] GameObject tubePrefab;
    [SerializeField] Transform _transform;
    float timeInterval = 2f;
    float timer = 0f;
    float offset = 0;

    void Start()
    {
        SpawnTube();
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeInterval)
        {
            timer = 0;
            SpawnTube();
        }
    }

    void SpawnTube()
    {
        offset = Random.Range(-1, 3);
        Vector3 newTubePos = new Vector3(_transform.position.x, _transform.position.y + offset, _transform.position.z);
        Instantiate(tubePrefab, newTubePos, _transform.rotation);
    }
}
