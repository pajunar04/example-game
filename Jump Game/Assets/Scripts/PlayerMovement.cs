using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public SpriteRenderer sp;
    private float moveInput;
    public float walkSpeed;

    public float jumpValue;
    public bool isGrounded;
    public bool isRightSide;
    public bool isLeftSide;
    public LayerMask groundMask;
    public Transform groundCheck;
    public Transform rightCheck;
    public Transform leftCheck;

    private float yPosition;

    public PhysicsMaterial2D bounceMat, normalMat;

    public Animator animator;

    [Header("Events")]
    public UnityEvent OnLandEvent;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        if (OnLandEvent == null)
            OnLandEvent = new UnityEvent();
    }



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {


        moveInput = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(moveInput));
        

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundMask);
        isRightSide = Physics2D.OverlapCircle(rightCheck.position, 0.2f, groundMask);
        isLeftSide = Physics2D.OverlapCircle(leftCheck.position, 0.2f, groundMask);


        if (Input.GetKey("space") && isGrounded)
        {
            jumpValue += 0.09f;
            
        }

        if (jumpValue >= 20.0f && isGrounded)
        {
            rb.velocity = new Vector2(moveInput * (jumpValue/3), jumpValue );
            

            Invoke("ResetJump", 0.2f);
            OnLandEvent.Invoke();


        }

        if (Input.GetKeyDown("space") && isGrounded)
        {
            
            rb.velocity = new Vector2(0.0f, rb.velocity.y);
            animator.SetBool("isJumping", true);

        }

        if (jumpValue == 5.0f && isGrounded)
        {
            rb.velocity = new Vector2(moveInput * walkSpeed, rb.velocity.y);
        }

        if (Input.GetKeyUp("space") && isGrounded)
        {
            rb.velocity = new Vector2(moveInput * (jumpValue/2), jumpValue);
            Invoke("ResetJump", 0.2f);
            OnLandEvent.Invoke();
            
        }

        if (isRightSide || isLeftSide)
        {
            rb.sharedMaterial = bounceMat;
        }
        else
        {
            rb.sharedMaterial = normalMat;
        }

        yPosition = rb.position.y - 6.0f;

        


        FlipPlayer();
    }

    public void FlipPlayer()
    {
        if (rb.velocity.x < -0.1f)
        {
            sp.flipX = true;
        }
        else if (rb.velocity.x > 0.1f)
        {
            sp.flipX = false;
        }
    }

    void ResetJump()
    {
        jumpValue = 5.0f;
    }

    
    public void OnLanding ()
    {
        animator.SetBool("isJumping", false);
    }
}
