using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBull : MonoBehaviour
{
    public Movement player;

    public int speed;

    public void update()
    {
        transform.Translate(player.SquareDirection * speed * Time.deltaTime);

    }
    


}
