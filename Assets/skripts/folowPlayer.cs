using UnityEngine;

public class folowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;


    void Update()
    {
        transform.position = Player.position + offset;
    }
}
