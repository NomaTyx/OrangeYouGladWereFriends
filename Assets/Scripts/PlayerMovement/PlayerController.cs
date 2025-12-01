using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float gravityForce = 1f;
    [SerializeField] private bool inGameplay = false;

    private Rigidbody rb;
    private float movementX;
    private float movementY;    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputValue movementValue)
    {
        Vector2 movementVec = movementValue.Get<Vector2>();

        movementX = movementVec.x;
        movementY = movementVec.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 movementDir = forward * movementY + right * movementX;

        rb.AddForce(movementDir * speed);

        if (inGameplay) {
            rb.AddForce(movementDir * speed);
        }
    }
}
