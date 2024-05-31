using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(ColorChanger))]
public class Cube : MonoBehaviour
{
    [SerializeField] private List <Transform> _spawnPoinsts;

    private ColorChanger _colorChanger;

    private void Awake()
    {
        _colorChanger = GetComponent<ColorChanger>();
    }

    public void OnCollisionWithPlatform()
    {
        if (_colorChanger.IscolorChanged == false)
            _colorChanger.ChangeColor();

        StartCoroutine(Return());
    }

    private IEnumerator Return()
    {
        int minWaitTime = 2;
        int maxWaitTime = 5;

        yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));

        _colorChanger.ResetColor();
        transform.position = _spawnPoinsts[Random.Range(0, _spawnPoinsts.Count)].position;
    }
}
