using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private Vector3 _direction;

    private void FixedUpdate()
    {
        transform.position = _direction.normalized * speed * Time.fixedDeltaTime;
    }
}
