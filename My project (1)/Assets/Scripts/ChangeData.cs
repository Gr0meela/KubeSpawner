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
        output.text = $"������� ������: \r\n\t����������: {cube.distance}\r\n\t��������: {cube.speed}\r\n\t�����: {spawn.time}";
    }
    public void Change()
    {
        cube.distance = float.Parse(distance.text);
        cube.speed = float.Parse(speed.text);
        spawn.time = float.Parse(time.text);

        output.text = $"������� ������: \r\n\t����������: {cube.distance}\r\n\t��������: {cube.speed}\r\n\t�����: {spawn.time}";
    }
}
