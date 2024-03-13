using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionInput : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;
    private PlayerActions playerActions;
    private Rigidbody rigidbody;
    private Vector2 movement;
    // [SerializeField] private Animator p_animator;


    private void Awake()
    {
        playerActions = new PlayerActions();
        rigidbody = GetComponent<Rigidbody>();

        if (rigidbody == null)
        {
            Debug.LogError("Rigidbody is NULL for Player");
        }
    }

    private void OnEnable()
    {
        playerActions.Gameplay.Enable();
    }

    private void OnDisable()
    {
        playerActions.Gameplay.Disable();
    }

    private void FixedUpdate()
    {
        movement = playerActions.Gameplay.Movement.ReadValue<Vector2>();
        rigidbody.velocity = new Vector3(movement.x, 0, movement.y) * speed;
    }

    // p_animator.SetBool("Running", moving);
    // transform.rotation = Quaternion.LookRotation(rigidbody.velocity);
}

