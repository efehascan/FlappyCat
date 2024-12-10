using UnityEngine;

public class Character : MonoBehaviour
{
    float verticalSpeed = 2.0f;
    
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
        
    void Start()
    {
        
    }
    
    void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Space) && IsGrounded())
        {
            transform.Translate(Vector2.up * Time.deltaTime * verticalSpeed);

        }
        
    }

    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
