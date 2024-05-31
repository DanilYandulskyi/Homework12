using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;

    private Renderer _renderer;
    private Color _baseColoor;

    public bool IscolorChanged => _color == _renderer.material.color;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _baseColoor = _renderer.material.color;
    }

    public void ChangeColor()
    {
        _renderer.material.color = _color;
    }

    public void ResetColor()
    {
        _renderer.material.color = _baseColoor;
    }
}
