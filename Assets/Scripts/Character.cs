using System;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    [SerializeField] public bool catIsDead = false;
    
    [SerializeField]float verticalSpeed = 4.5f;
    [SerializeField]float rotationSpeed = 10.0f;
    [SerializeField] TextMeshProUGUI pointsText;
    public int points;

    
    
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
        UpdatePoints();
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,rb2d.linearVelocity.x * rotationSpeed);
    }

    void UpdatePoints()
    {
        pointsText.text = "Score:" + points.ToString();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PointCollider"))
        {
            points++;
        }
    }
}
