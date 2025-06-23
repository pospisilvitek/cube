using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
        // Debug.Log("Ahoj"); napise do konzole Ahoj
        // rb.useGravity = false; nastaveni fyziky rb na false
        // rb.AddForce(0, 200, 500); kopnuti do objektu
    // }

    public Rigidbody rb; // deklarace promemmne rb pro fyziku rigidbody
    
    public float forwardForce = 500f;
    public float sidewaysForce = 1500f;

    // Update is called once per frame
    void FixedUpdate() // nebo jen void Update
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}