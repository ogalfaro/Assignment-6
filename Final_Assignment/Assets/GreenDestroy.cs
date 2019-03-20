using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GreenDestroy : MonoBehaviour
{
    public GameObject FloatingText;
    public float Fifty = 50f;
    public float Hundred = 100f;
    public float TwoHundred = 200f;
  
        /// <summary>
        /// OnCollisionEnter is called when this collider/rigidbody has begun
        /// touching another rigidbody/collider.
        /// </summary>
        /// <param name="other">The Collision data associated with this collision.</param>
        private void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.tag == "Cube" || other.gameObject.name == "Catch"){
                Destroy(this.gameObject); 
            }
            if(other.gameObject.name == "GreenAsteroid(Clone)"){
                if(FloatingText){
                    ShowFloatingText(TwoHundred);  
                }
                Score.scoreValue += 200f;
                Destroy(this.gameObject);
            }
            if(other.gameObject.name == "Player"){
                if(FloatingText){
                    ShowFloatingText(Hundred);  
                }
                Score.scoreValue += 100f;
                Destroy(this.gameObject);
            }
            if(other.gameObject.name == "RightFlipper" || other.gameObject.name == "LeftFlipper"){
                if(FloatingText){
                    ShowFloatingText(Fifty);
                } 
                Score.scoreValue += 50f; 
            }
            if(other.gameObject.name == "Button1" || other.gameObject.name == "Button2"){
                if(DestroyScript.Life > 0f){
                    DestroyScript.Life --;
                } 
            }
        }

        void ShowFloatingText(float x){
            var go = Instantiate(FloatingText,transform.position,Quaternion.identity);
            go.GetComponent<TextMesh>().text = x.ToString(); 
        }
        
    
}
