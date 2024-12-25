using System;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1.65f;
    Character character;

    void Update()
    {
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("MainCamera"))
        {
            Destroy(this.gameObject);
        }
    }
}