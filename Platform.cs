using UnityEngine;

public class Platform : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Cube cube))
            cube.OnCollisionWithPlatform();
    }
}