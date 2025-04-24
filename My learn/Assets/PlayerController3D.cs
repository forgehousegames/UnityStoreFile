using UnityEngine;

public class PlayerController3D : MonoBehaviour
{
    public float movespeed = 5f;
    private Rigidbody rb;
    private Vector3 movement;

    public void Start() { rb = GetComponent<Rigidbody>(); }

    public void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");

        movement = movement.normalized;
    }

    public void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter(Collider other) 
    {
        Debug.Log("you hit something" + other.name);
    }
}
