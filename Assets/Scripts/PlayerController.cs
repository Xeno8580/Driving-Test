using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float forwardInput;
    public float speed = 20.0f;
    public float turnSpeed = 45.0f;
    public bool isMoving;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // input management
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // this makes car go forward with input
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            isMoving = true;
        }
        if (!Input.anyKey)
        {
            isMoving = false;
        }
        
        Debug.Log(isMoving);
        // rotates car bases on horizontal input
        if (isMoving != true)
        {
            return;
        }
        else
        {
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }
    }
}
