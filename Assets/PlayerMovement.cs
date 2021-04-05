using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start() {


        // rb.useGravity = false;

     //   rb.AddForce(500, 200, 0);

       //  Debug.Log("Hello, World!");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(-2000 * Time.deltaTime, 0, 0);
    }
}
