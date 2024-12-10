using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    [SerializeField]float verticalSpeed = 1.5f;
    
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    
    Rigidbody2D rb2d;
        
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb2d.linearVelocity = Vector2.up * verticalSpeed;

        }
        
    }
}
