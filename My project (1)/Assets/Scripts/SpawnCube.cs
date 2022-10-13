using System.Collections;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private SpawnData spawn;
    private float time;
    private void Start()
    {
        StartCoroutine(DoSpawn());
    }
    private void Update()
    {
        time = spawn.time;
    }
    IEnumerator DoSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Instantiate(cube, transform.position, Quaternion.identity);
        }
    }
}
