using UnityEngine;
using UnityEngine.InputSystem;

public class BulletController : MonoBehaviour
{
    private Rigidbody rb;
    public float velocity;
    public Vector3 direction;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.linearVelocity = direction * velocity;
    }
}