using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MariaTsangaris
{
    /// <summary>
    /// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining XP and detecting when we should level up.
    /// </summary>
    public class LevellingSystem : MonoBehaviour
    {
        // TODO XP 1/13 Declare a new variable to track the current amount of XP we have accumulated (our current XP).
        public int experience = 0; // Variable for experience.

        // TODO XP 2/13 Declare a new variable to track our current Level.
        public int level = 0; // Variable for level.

        // TODO XP 3/13 Declare a new variable to track the amount of XP required to level-up (our current Level Up Threshold).
        public int levelUp = 100; // Variable for level up requirement.

        public GameObject player;

        private void Start()
        {
            // TODO XP 4/13: Set our current level to one.
            level += 1; // Setting our level value from 0 to 1.

            // TODO XP 5/13: Set our current XP to zero.
            experience = 0; // Setting our experience value to zero.

            // TODO XP 6/13: Set our current XP Threshold to be our level multiplied by our 100.
            levelUp = level * 100; // Setting our xp threshold (levelUp) to be = to our current level * 100.

            // TODO XP 7/13: Debug out our starting values of our level, XP and current XP threshold.
            Debug.Log("Our Level " + level);
            Debug.Log("Our XP " + experience);
            Debug.Log("Our current XP threshold " + levelUp); // Showing our current XP and levelUp in the Debug Log.

            // TODO XP 8/13: Increase the current XP by a random amount between 50 and 100.
            experience = experience + Random.Range(100, 150); // Adding a random amount of experience from 100 to 150.

            // TODO XP 9/13: Debug out our current XP.
            Debug.Log("Updated XP " + experience); // Showing our new current XP in the Debug Log.

            // TODO XP 10/13: Check if our current XP is more than our threshold.
            if (experience >= levelUp) // Checking if our experience is greater than or = to our current XP threshold (levelUp).
            {
                // TODO XP 11/13: If it is, then let's increase out level by one.
                level += 1; // Increasing our level by one.
                Debug.Log("New Level " + level); 

                experience -= levelUp; // Removing amount of experience used to level up.
                Debug.Log("Updated XP " + experience);

                // TODO XP 12/13: Let's also increase recalculate our current XP threshold as we've levelled up.
                levelUp = level * 100; // Increasing current XP threshold to be = to current level * 100.
                Debug.Log("New current XP threshold " + levelUp);

                // TODO XP 13/13: Debug out our new level value, as well as our current XP and the next threshold we need to hit.
            }

            // TODO XP Final: Add code comments describing what you hope your code is doing throughout this script.


        }
        // TODO XP Bonus: Adjust our character's stats ("runSpeed" and/or "jumpStrength") based on their level. (Hint: You'll need a reference to the SimpleCharacterController script!)

        private void Update()
        {
            if (experience >= levelUp)
            {
                level += 1; // Increasing our level by one.
                Debug.Log("New Level " + level);

                experience -= levelUp; // Removing amount of experience used to level up.
                Debug.Log("Updated XP " + experience);

                levelUp = level * 100; // Increasing current XP threshold to be = to current level * 100.
                Debug.Log("New current XP threshold " + levelUp);

                player.GetComponent<SimpleCharacterController>().speed = player.GetComponent<SimpleCharacterController>().speed + 1; // Grabbing the SimpleCharacterController and accessing the speed value and adding it by 1.
                player.GetComponent<SimpleCharacterController>().jump = player.GetComponent<SimpleCharacterController>().jump + 1; // Same as above but accessing jump value indeed.

            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                experience = experience + Random.Range(20, 60);
                Debug.Log("Added XP from 'E' " + experience); // Pressing down 'E' key adds a random amount of XP from 20 to 60.
            }

        }
    }
}
