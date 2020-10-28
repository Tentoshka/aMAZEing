using UnityEngine;

public class PlayerControls3D : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 4;

    private void Start()
    {
    }

    private void Update()
    {
       float x = Input.GetAxis("Horizontal");
       float z = Input.GetAxis("Vertical");
       
       Vector3 move = transform.right * x + transform.forward * z;
       
       controller.Move(move * speed * Time.deltaTime);
    }
}
