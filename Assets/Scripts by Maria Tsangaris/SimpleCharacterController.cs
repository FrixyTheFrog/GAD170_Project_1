using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MariaTsangaris
{
    /// <summary>
    /// This class holds all the variables and functionality for moving our character around our game world.
    /// </summary>
    public class SimpleCharacterController : MonoBehaviour
    {
        [SerializeField] private float horizontalInputValue; // The value of our horizontal input axis.
        [SerializeField] private SpriteRenderer spriteRenderer; // Our character's sprite.

        // TODO Movement 1/8: Declare a variable for a reference to our 2D rigidbody, for physics stuff.
        public Rigidbody2D player; // Variabe for RigidBody2D.

        // TODO Movement 2/8: Declare a variable for the speed we can run at in Unity-units-per-second.
        public float speed = 1.5f; // Variable for speed.

        // TODO Movement 3/8: Declare a variable for the strength of our jump.
        public float jump = 1.5f; // Variable for jump.

        private float horizontalMovementValue = 0f; // Variable for movement.

        private void Update()
        {
            // TODO Movement 4/8: Store our horizontal player input value so we can access it later on.
            horizontalMovementValue = Input.GetAxisRaw("Horizontal"); // Getting the horizontal input for left and right.

            // TODO Movement 5/8: Transform our character's position on the X axis. (Reference our stored horizontal input value here!)
            transform.position += Time.deltaTime * speed * new Vector3(horizontalMovementValue, 0); // Moving the position of the character * game speed * set speed.

            // TODO Movement 6/8: Check if the player presses the "Jump" button (by default, the space bar on the keyboard).
            if (Input.GetButtonDown("Jump")) // Checking to see if the jump button (space bar) is being pressed.
            {

                // ...then add vertical velocity to make their character "jump"!
                player.velocity = new Vector3(player.velocity.x, jump); // Adding velocity to allow the character to jump when pressing the space bar.
            }

            // TODO Movement 7/8: If they do, then add vertical velocity to our rigidbody to make our character "jump"!

            // TODO Movement 8/8: Add this script to a game object and make a new prefab from it, and explore the level!

            // TODO Movement Final: Add code comments describing what you hope your code is doing throughout this script.

            // TODO Movement Bonus 1: Ensure that our character can only jump if they are "grounded". (Hint: You can use a boolean as a part of this!)

            // TODO Movement Bonus 2: Flip our character's sprite so that it faces left/right if we are moving left/right. (Hint: A SpriteRenderer reference, and changing its FlipX = true/false will help!)

        }
    }
}
