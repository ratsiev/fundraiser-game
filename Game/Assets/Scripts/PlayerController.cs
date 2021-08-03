using UnityEngine;
using System.Collections;

public class PlayerController : ActorController {

    [SerializeField] Camera cam;
    [SerializeField] LayerMask aimLayer;

    Vector3 mousePosition;

    void Update() {
        Move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        Aim();
        // animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void Dash() {

    }


    void Aim() {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, aimLayer)) {
            mousePosition = hit.point;
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(mousePosition, 0.1f);
    }
}
  