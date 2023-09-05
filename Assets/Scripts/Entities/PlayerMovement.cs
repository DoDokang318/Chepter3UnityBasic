using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;
    public GameObject MainPlayer;
    private Animator _animator;

    private AudioSource _audioSource;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = MainPlayer.GetComponent<Animator>();
    }
    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }
    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }
    private void ApplyMovement(Vector2 direction)
    {
        Vector2 velocity = direction * 5;
        _rigidbody.velocity = velocity;

        if (direction.x != 0 || direction.y != 0)
        {
            _animator.SetBool("Boolwalk", true);
        }
        else 
        {
            _animator.SetBool("Boolwalk", false);
        }

    }
}
