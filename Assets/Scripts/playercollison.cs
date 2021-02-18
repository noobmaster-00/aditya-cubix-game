
using UnityEngine;

public class playercollison : MonoBehaviour
{
    public playermov movement;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
