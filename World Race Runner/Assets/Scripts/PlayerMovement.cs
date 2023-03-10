
using System;
using UnityEngine;
using UnityEngine.Serialization;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private Rigidbody rb;
    [SerializeField] private float jumpHeight = 300;
    [SerializeField] private bool grounded;
    [SerializeField] private LayerMask mask;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var direction = new Vector3(horizontal, 0, 0);

        MoveHorizontal(direction);

        CheckGround();

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
        }
    }

    private void MoveHorizontal(Vector3 moveHorizontal)
    {
        transform.position += moveHorizontal * (speed * Time.deltaTime);
    }

    private void CheckGround()
    {
        RaycastHit hitInfo = new RaycastHit();
        
        if (Physics.Raycast(transform.position, -Vector3.up, out hitInfo, 0.6f, mask))
        {
            grounded = true;
        }else
        {
            grounded = false;
        }
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpHeight);
    }
    
}
