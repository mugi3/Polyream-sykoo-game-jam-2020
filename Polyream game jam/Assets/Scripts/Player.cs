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
        //float verticalMovement = Input.GetAxis("Vertical");
        horizontalMovement = horizontalMovement * Time.deltaTime * moveSpeed;
        horizontalMovement += transform.position.x;
        //verticalMovement = verticalMovement * Time.deltaTime * moveSpeed;
        //verticalMovement += transform.position.y;
        //transform.position = new Vector2(horizontalMovement, verticalMovement);
        transform.position = new Vector2(horizontalMovement, transform.position.y);
    }
}
