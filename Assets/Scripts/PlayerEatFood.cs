using UnityEngine;

public class Player : MonoBehaviour
{
    // You can remove health and energy entirely as no longer needed

    // Method to handle eating food
    public void EatFood()
    {
        // Simply log when food is eaten
        Debug.Log("Player ate food!");
    }
}