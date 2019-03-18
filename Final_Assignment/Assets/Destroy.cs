using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject FloatingText;
    public float Asteroid = 50f;
  
        /// <summary>
        /// OnCollisionEnter is called when this collider/rigidbody has begun
        /// touching another rigidbody/collider.
        /// </summary>
        /// <param name="other">The Collision data associated with this collision.</param>
        private void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.tag == "Cube" || other.gameObject.name == "Catch" || other.gameObject.name == "MediumAsteroid(Clone)" || other.gameObject.name == "Player"){
                Destroy(this.gameObject); 
            }
            if(other.gameObject.name == "RightFlipper" || other.gameObject.name == "LeftFlipper"){
                if(FloatingText){
                    ShowFloatingText();
                }  
            }
        }

        void ShowFloatingText(){
            var go = Instantiate(FloatingText,transform.position,transform.rotation);
            go.GetComponent<TextMesh>().text = Asteroid.ToString(); 
        }
        
    
}
