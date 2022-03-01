using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    float moveX;
    [SerializeField]
    float jump = 5.0f;

    [SerializeField]
    float moveSpeed = 5.0f;

    bool isGrounded;
    bool canJump;

    [SerializeField]
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Awake()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            player.position = new Vector2(-6.0f, -4.0f);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            player.position = new Vector2(36.0f, -4.0f);
        }
    }
    void PlayerControls()
    {
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canJump = true;
        }

    }

    void Jump()
    {
        if (!isGrounded)
            return;
        isGrounded = false;
        rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
        if (canJump)
        {
            canJump = false;
            Jump();
        }
    }

    // Update is called once per frame. Movement stuff
    void Update()
    {
        PlayerControls();
    }
}
