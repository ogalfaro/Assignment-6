using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 30; 
    private int face = 1;

   
    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw ("Horizontal");
        float moveVertical = Input.GetAxisRaw ("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.rotation = Quaternion.LookRotation(movement);
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);
        //transform.Translate (movement * speed * Time.deltaTime, Space.World);

         if (Input.GetKey(KeyCode.A)){
             rb.AddForce(0,0,-speed);
             if(face == 1){
                 
             }   
         }
         if (Input.GetKey(KeyCode.D)){
             rb.AddForce(0,0,speed);
         }
    }

}
