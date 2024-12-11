using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1.35f;
    
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
