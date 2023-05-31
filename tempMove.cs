using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempMove : MonoBehaviour
{
    public static float jumpForce = 225f;
    public static float speed = 165f;

    public static float tempjumpForce = 225f;
    public static float tempspeed = 165f;

    private Rigidbody2D rb;

    public Transform groundPos;
    private bool isGrounded;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;

    private Animator anim;

    public static float artistHealthAmount = 600f;

    public static float tempartistHealthAmount = 600f;

    int Artistattacklevel = 0;
    int Artisthealthlevel = 0;
    int Artistspeedlevel = 0;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        Artistattacklevel = PlayerPrefs.GetInt("Artistattacklevel");
        Artisthealthlevel = PlayerPrefs.GetInt("Artisthealthlevel");
        Artistspeedlevel = PlayerPrefs.GetInt("Artistspeedlevel");

        artistHealthAmount += PlayerPrefs.GetInt("Artisthealthlevel") * 60;
        jumpForce += PlayerPrefs.GetInt("Artistspeedlevel") * 3;
        speed += PlayerPrefs.GetInt("Artistspeedlevel") * 4;
    }

    private void Update()
    {

        isGrounded = Physics2D.OverlapCircle(groundPos.position, checkRadius, whatIsGround);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("takeOff");
            isJumping = true;

            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (isGrounded == true)
        {
            anim.SetBool("isJumping", false);
        }
        else
        {
            anim.SetBool("isJumping", true);
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }


        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        if (direction.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (direction.x < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
