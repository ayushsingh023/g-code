using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;


    public float forwardForce = -800f;
    public float sidewaysForce = 500f;



    // Start is called before the first frame update
    void Start() 
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0);

        if ( Input.GetKey ("d") )
        {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime);
        }

        if ( Input.GetKey ("a") )
        {
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime);
        }
    }
}
