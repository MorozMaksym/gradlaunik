using UnityEngine;

public class Triger : MonoBehaviour
{
    public GameManeger gameManeger;

    void OnTriggerEnter()
    {
        gameManeger.comliteLevl();
    }


}
