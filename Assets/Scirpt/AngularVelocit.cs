using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float angularSpeed;

    Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if(Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, angularSpeed, 0);
        }
        
        if(Keyboard.current.aKey.isPressed )
        {
            rb.angularVelocity = new Vector3(0, 0, 0);
        }




    }







    // Update is called once per frame
    void Update()
    {
      
    }
}
