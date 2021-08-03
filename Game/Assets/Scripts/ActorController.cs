using UnityEngine;
using System.Collections;

public class ActorController : MonoBehaviour {

    [SerializeField] float speed = 5f;
    [SerializeField] protected CharacterController controller;
    [SerializeField] protected Animator animator;

    Vector3 forward, right;
    Vector3 movement;

    void Start() {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);

        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
    }

    protected void Move(Vector2 pos) {
        Vector3 horizontal = pos.x * right;
        Vector3 vertical = pos.y * forward;
        movement = horizontal + vertical;

        Vector3 facingDirection = Vector3.Normalize(horizontal + vertical);

        controller.Move(speed * Time.deltaTime * movement.normalized);
        if (facingDirection != Vector3.zero)
            transform.forward = facingDirection;
    }
}