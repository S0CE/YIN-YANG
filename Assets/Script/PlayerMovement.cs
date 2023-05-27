using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float moveSpeed;
	public float jumpForce;
	
	public bool isJumping;
	public bool isGrounded;
	
	public Transform groundCheck;
	public float groundCheckSize;
	public LayerMask collisionlayer;
	
	public Rigidbody2D rb;
	public Animator animator;
	public SpriteRenderer spriteRenderer;
	
	private Vector3 velocity = Vector3.zero;
	private float horizontalMovement;

	void Update()
	{
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckSize, collisionlayer);
		
        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
			isJumping = true;
		}
        
        Flip(rb.velocity.x);
        
        float characterVelocity = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("Speed", characterVelocity);
	}

    void FixedUpdate()
    {
        MovePlayer(horizontalMovement);
    }
    
    void MovePlayer(float _horizontalMovement)
    {
		Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
		rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
		
		if (isJumping == true)
		{
			rb.AddForce(new Vector2(0f, jumpForce));
			isJumping = false;
		}
	}
	
	void Flip(float _velocity)
	{
		if (_velocity > 0.1f) {
			spriteRenderer.flipX = false;
		} else if (_velocity < -0.1f ){
			spriteRenderer.flipX = true;
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(groundCheck.position, groundCheckSize);
	}
}
