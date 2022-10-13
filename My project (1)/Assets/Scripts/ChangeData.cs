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

    private void Start()
    {
        SetText();
    }
    public void Change()
    {
        if (!string.IsNullOrEmpty(distance.text) || !string.IsNullOrEmpty(speed.text) || !string.IsNullOrEmpty(time.text))
        {
            cube.distance = float.Parse(distance.text, System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            cube.speed = float.Parse(speed.text, System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            spawn.time = float.Parse(time.text, System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            SetText();
        }
    }
    private void SetText()
    {
        output.text = $"Текущие данные: \r\n\tРасстояние: {cube.distance}\r\n\tСкорость: {cube.speed}\r\n\tВремя: {spawn.time}";
    }
}
