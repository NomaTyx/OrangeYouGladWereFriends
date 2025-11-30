using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
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
        Vector3 movementDir = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movementDir * speed);
    }
}
