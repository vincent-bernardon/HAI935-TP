using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement2 : MonoBehaviour
{
 public InputAction MoveAction;
 public float walkSpeed = 1.0f;
 public float turnSpeed = 20f;
 Rigidbody m_Rigidbody;
 Vector3 m_Movement;
 Animator m_Animator;
 Quaternion m_Rotation = Quaternion.identity;
 void Start ()
 {
 m_Rigidbody = GetComponent<Rigidbody> ();
 m_Animator = GetComponent<Animator> () ;
 MoveAction.Enable();
 }
 void FixedUpdate ()
 {
 var pos = MoveAction.ReadValue<Vector2>();

 float horizontal = pos.x;
 float vertical = pos.y;

 m_Movement.Set(horizontal, 0f, vertical);
 m_Movement.Normalize ();
 bool hasHorizontalInput = !Mathf.Approximately (horizontal, 0f);
bool hasVerticalInput = !Mathf.Approximately (vertical, 0f);
bool isWalking = hasHorizontalInput || hasVerticalInput;
m_Animator.SetBool ("isWalking", isWalking);
 Vector3 desiredForward = Vector3.RotateTowards (transform.forward, m_Movement, turnSpeed *
Time.deltaTime, 0f);
 m_Rotation = Quaternion.LookRotation (desiredForward);

 m_Rigidbody.MoveRotation (m_Rotation);
 m_Rigidbody.MovePosition (m_Rigidbody.position + m_Movement * walkSpeed * Time.deltaTime);
 }
}