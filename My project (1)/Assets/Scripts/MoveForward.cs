using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private CubeData cubeData;
    private float speed;
    private float distance;
    private float progress;
    private Vector3 start;
    private Vector3 finish;
    void Awake()
    {
        speed = cubeData.speed;
        distance = cubeData.distance;
        start = transform.position;
        finish = start + Vector3.forward * distance;
    }
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(start, finish, progress);
        progress += speed/ 250f;

        if (transform.position == finish)
            Destroy(gameObject);
    }
}
