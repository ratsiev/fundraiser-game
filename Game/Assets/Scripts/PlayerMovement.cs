using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;

    private Vector2 movement;

    private void Update() {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate() {
        Move();
    }

    void Move() {
        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);

    }
}
