using UnityEngine;

[ExecuteInEditMode]
public class WaterFarColorSetter : MonoBehaviour
{
#pragma warning disable CS0649
    [SerializeField] private Material _waterActiveMaterial;
    private Material _currentMaterial;
#pragma warning restore CS0649

    void Awake()
    {
        _currentMaterial = GetComponent<Renderer>().sharedMaterial;

        if (_currentMaterial == null && _waterActiveMaterial == null)
        {
            enabled = false;
            Debug.LogWarning($"Some Materials in {gameObject.name} is null, color cant be set");
        }
    }

    void Update()
    {
        _currentMaterial.color = _waterActiveMaterial.GetColor("Color_A13A931D"); //Water Far
    }
}
