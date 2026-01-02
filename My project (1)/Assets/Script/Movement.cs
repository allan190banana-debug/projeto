using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public InputAction PlayerControls;
    public float moveSpeed = 5f;
    private Vector2 movementDirection=Vector2.zero;
    void OnEnable()
    {
        PlayerControls.Enable();
    }
    void OnDisable()
    {
        PlayerControls.Disable();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void FixedUpdate()
    {
        movementDirection = PlayerControls.ReadValue<Vector2>();
        myRigidbody.linearVelocity = movementDirection * moveSpeed;
    }
}
