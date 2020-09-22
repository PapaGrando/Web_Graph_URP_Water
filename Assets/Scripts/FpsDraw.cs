using UnityEngine;
using UnityEngine.UI;

public class FpsDraw : MonoBehaviour
{
    public Text _fpsText;
    public float _deltaTime;

    private void Awake()
    {
        _fpsText = GetComponent<Text>();

    }
    void Update()
    {
        _deltaTime += (Time.deltaTime - _deltaTime) * 0.1f;
        float fps = 1.0f / _deltaTime;
        _fpsText.text = Mathf.Ceil(fps).ToString() + "FPS";
    }
}
