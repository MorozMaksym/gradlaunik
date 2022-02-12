using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMoovment moovment;
     void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            moovment.enabled = false;
            FindObjectOfType<GameManeger>().Endgame();
        }
    }
}
