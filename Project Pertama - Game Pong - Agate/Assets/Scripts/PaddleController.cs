using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;

    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;

    public bool scaleUp = false;
    public bool speedUp = false;

    public int durationScaleUp;
    public int durationSpeedUp;

    private float timer;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        MoveObject(GetInput());

        if(scaleUp == true)
        {
            timer += Time.deltaTime;

            if(timer > durationScaleUp)
            {
                DeactivePUPaddleScaleUp();
                scaleUp = false;
                timer = 0;
            }
        }

        if(speedUp == true)
        {
            timer += Time.deltaTime;

            if(timer > durationSpeedUp)
            {
                DeactivePUPaddleSpeedUp();
                speedUp = false;
                timer = 0;
            }
        }
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        //Debug.Log("TEST: " + movement);
        rig.velocity = movement;
    }

    public void ActivePUPaddleScaleUp()
    {
        gameObject.transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y * 2);
        scaleUp = true;
    }

    public void DeactivePUPaddleScaleUp()
    {
        gameObject.transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y / 2);
    }

    public void ActivePUPaddleSpeedUp()
    {
        speed *= 2;
        speedUp = true;
    }

    public void DeactivePUPaddleSpeedUp()
    {
        speed /= 2;
    }
}
