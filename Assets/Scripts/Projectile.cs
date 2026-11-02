using UnityEngine;

public class Projectile : MonoBehaviour
{
    float _velocity;
    
    void Update()
    {
        transform.position += Time.deltaTime * _velocity * Vector3.right;
    }

    public void SetVelocity(float velocity)
    {
        _velocity = velocity;
    }
}
