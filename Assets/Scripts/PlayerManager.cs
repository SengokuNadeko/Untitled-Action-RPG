using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private float movement_speed = 5;
    private Vector2 movement_direction;
    private Vector2 last_movement_direction;
   
    [SerializeField]private Rigidbody2D player_rigidbody;
    [SerializeField]private Animator player_animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
        Movement();
        PlayWalkingAnimation();
    }

    void Inputs() 
    {
        if (movement_direction.x != 0 || movement_direction.y != 0) 
        {
            last_movement_direction = movement_direction;
        }

        movement_direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    void Movement() 
    {
        player_rigidbody.velocity = new Vector2(movement_direction.x * movement_speed, movement_direction.y * movement_speed);
    }

    void PlayWalkingAnimation()
    {
        player_animator.SetFloat("move_direction_x", movement_direction.x);
        player_animator.SetFloat("move_direction_y", movement_direction.y);
        player_animator.SetFloat("last_move_direction_x", last_movement_direction.x);
        player_animator.SetFloat("last_move_direction_y", last_movement_direction.y);
        player_animator.SetFloat("movement_magnitude", movement_direction.magnitude);
    }
}
