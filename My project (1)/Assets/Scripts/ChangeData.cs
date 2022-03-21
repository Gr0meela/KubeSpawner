using UnityEngine;
using UnityEngine.UI;

public class ChangeData : MonoBehaviour
{
    [SerializeField] private SpawnData spawn;
    [SerializeField] private CubeData cube;

    [SerializeField] private InputField distance;
    [SerializeField] private InputField speed;
    [SerializeField] private InputField time;

    [SerializeField] private Text output;

    private void Awake()
    {
        output.text = $"Текущие данные: \r\n\tРасстояние: {cube.distance}\r\n\tСкорость: {cube.speed}\r\n\tВремя: {spawn.time}";
    }
    public void Change()
    {
        cube.distance = float.Parse(distance.text);
        cube.speed = float.Parse(speed.text);
        spawn.time = float.Parse(time.text);

        output.text = $"Текущие данные: \r\n\tРасстояние: {cube.distance}\r\n\tСкорость: {cube.speed}\r\n\tВремя: {spawn.time}";
    }
}
