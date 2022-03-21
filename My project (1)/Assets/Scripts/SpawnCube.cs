using System.Collections;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private SpawnData spawn;
    private float time;
    private void Awake()
    {
        StartCoroutine(DoSpawn());
    }
    void FixedUpdate()
    {
        time = spawn.time;
    }
    IEnumerator DoSpawn()
    {
        Instantiate(cube);
        yield return new WaitForSeconds(time);
        StartCoroutine(DoSpawn());
    }
}
