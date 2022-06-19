using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float magnitude;
    public int removeInterval;

    private float timer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            ball.GetComponent<BallController>().ActivatePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer > removeInterval)
        {
            manager.RemovePowerUp(gameObject);
        }
    }
}
