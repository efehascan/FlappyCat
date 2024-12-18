using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    [SerializeField] public bool catIsDead = false;
    
    [SerializeField]float verticalSpeed = 4.5f;
    [SerializeField]float rotationSpeed = 10.0f;
    
    
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

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,rb2d.linearVelocity.x * rotationSpeed);
        
    }
}
