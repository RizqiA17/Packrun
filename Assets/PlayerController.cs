using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int position;
    private bool isGrounded;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce = 15, groundDistance = .1f;
    [SerializeField] private Vector3 substracPos = new Vector3(0, 1, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))) position++;
        else if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))) position--;

        transform.position = new Vector3(0, transform.position.y, position * 2);

        if (isGrounded)
        {
            bool jump = Input.GetAxis("Vertical") > 0 || Input.GetButton("Jump");
            if (jump) rb.AddForce(0, jumpForce, 0);
        }
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position - substracPos, Vector3.down, groundDistance);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
