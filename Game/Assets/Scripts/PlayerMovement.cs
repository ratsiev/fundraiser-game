using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] float speed = 5f;
    [SerializeField] CharacterController controller;
    [SerializeField] Animator animator;

    Vector3 forward, right;
    Vector3 movement;

    void Start() {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);

        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
    }

    void Update() {
        Move();
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void Move() {
        Vector3 horizontal = Input.GetAxis("Horizontal") * right;
        Vector3 vertical = Input.GetAxis("Vertical") * forward;
        movement = horizontal + vertical;

        Vector3 facingDirection = Vector3.Normalize(horizontal + vertical);

        /*
        Vector3 movement = transform.position;
        movement += horizontal;
        movement += verticall; */

        controller.Move(speed * Time.deltaTime * movement.normalized);
        if (facingDirection != Vector3.zero)
            transform.forward = facingDirection;
    }
}