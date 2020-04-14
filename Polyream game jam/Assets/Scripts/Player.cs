using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    [Header("Settings")]
    public float moveSpeed;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        CalculateMovements();
    }
    void CalculateMovements()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");

        if (Mathf.Abs(horizontalMovement) > Mathf.Epsilon)
        {
            horizontalMovement = horizontalMovement * Time.deltaTime * moveSpeed;
            horizontalMovement += transform.position.x;
            transform.position = new Vector2(horizontalMovement, transform.position.y);
        }

    }
}
