using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper_Script : MonoBehaviour
{
    public static float jumpForce = 355f;
    public static float speed = 155f;

    public static float tempjumpForce = 355f;
    public static float tempspeed = 155f;

    private Rigidbody2D rb;

    public Joystick joystick;
    public Joystick fireJoystick;

    public Transform groundPos;
    private bool isGrounded;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;

    int Sniperattacklevel = 0;
    int Sniperhealthlevel = 0;
    int Sniperspeedlevel = 0;

    private Animator anim;

    private CapsuleCollider2D cap;

    public static float sniperHealthAmount = 460f;

    public static float tempsniperHealthAmount = 460f;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        cap = GetComponent<CapsuleCollider2D>();

        Sniperattacklevel = PlayerPrefs.GetInt("Sniperattacklevel");
        Sniperhealthlevel = PlayerPrefs.GetInt("Sniperhealthlevel");
        Sniperspeedlevel = PlayerPrefs.GetInt("Sniperspeedlevel");

        sniperHealthAmount += PlayerPrefs.GetInt("Sniperhealthlevel") * 50;
        jumpForce += PlayerPrefs.GetInt("Sniperspeedlevel") * 3;
        speed += PlayerPrefs.GetInt("Sniperspeedlevel") * 4;
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundPos.position, checkRadius, whatIsGround);

        float moveInput = joystick.Horizontal;


        if (joystick.Horizontal >= .2f)
        {
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        }
        else if (joystick.Horizontal <= -.2f)
        {
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }


        float verticalMove = joystick.Vertical;
        float verticalVelocity = rb.velocity.y;

        if (verticalVelocity > 0){
            cap.enabled = false;
        }
        else{
            cap.enabled = true;
        }

        if (isGrounded == true && (verticalMove >= 0.4))
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

        if ((verticalMove >= 0.4) && isJumping == true)
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

        if ((verticalMove >= 0.4))
        {
            isJumping = false;
        }


        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }

        if (fireJoystick.Horizontal > 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (fireJoystick.Horizontal < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
