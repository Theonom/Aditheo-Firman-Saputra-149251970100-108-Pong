using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleScaleUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public int removeInterval;

    public GameObject paddleRight;
    public GameObject paddleLeft;

    public BallController ballController;

    private float timer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (ballController.isRight)
            {
                paddleRight.GetComponent<PaddleController>().ActivePUPaddleScaleUp();
                manager.RemovePowerUp(gameObject);
            }
            else
            {
                paddleLeft.GetComponent<PaddleController>().ActivePUPaddleScaleUp();
                manager.RemovePowerUp(gameObject);
            }
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
