// 19/09/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using UnityEngine;
using UnityEngine.InputSystem;

public class RotateWithInput : MonoBehaviour
{
    [SerializeField, Tooltip("Rotation speed in degrees per second.")]
    private float rotationSpeed = 45f;

    private void Update()
    {
        // Check if the left arrow key is pressed
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            // Rotate the GameObject about the Y-axis in the negative direction
            transform.Rotate(0f, -rotationSpeed * Time.deltaTime, 0f);
        }

        // Check if the right arrow key is pressed
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            // Rotate the GameObject about the Y-axis in the positive direction
            transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        }
    }
}