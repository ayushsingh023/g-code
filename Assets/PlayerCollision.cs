using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
      //  Debug.Log(collisionInfo.collider.name);  
      if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
          //  Debug.Log("we hit an obstacle");
        }
    }

}
