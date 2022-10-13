using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private CubeData cubeData;
    private Vector3 finish;
    private float speed;
    private float distance;
    private float delta;
    private void Start()
    {
        speed = cubeData.speed;
        distance = cubeData.distance;
        finish = transform.position + Vector3.forward * distance;
    }
    private void Update()
    {
        delta = Time.deltaTime * speed;
        transform.position = Vector3.MoveTowards(transform.position, finish, delta);
        if (transform.position == finish)
            Destroy(gameObject);
    }
}
