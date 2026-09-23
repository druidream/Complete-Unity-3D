using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float xClamp = 3f;
    [SerializeField] float zClamp = 3f;

    Vector2 movement;
    Rigidbody rigidbody;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        HandleMovement();
    }

    public void Move(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
        // Debug.Log(movement);
    }

    void HandleMovement()
    {
        Vector3 currentPosition = rigidbody.position;
        Vector3 moveDirection = new Vector3(movement.x, 0f, movement.y);
        Vector3 newPostion = currentPosition + moveDirection * (moveSpeed * Time.fixedDeltaTime);
        newPostion.x = Mathf.Clamp(newPostion.x, -xClamp, xClamp);
        newPostion.z = Mathf.Clamp(newPostion.z, -zClamp, zClamp);

        rigidbody.MovePosition(newPostion);
    }
}
