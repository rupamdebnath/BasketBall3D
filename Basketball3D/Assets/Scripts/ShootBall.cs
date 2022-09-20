using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class ShootBall : MonoBehaviour
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;

    private Rigidbody rb;

    private bool isShoot;
    int score = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        //rb.useGravity = true;
        mousePressDownPos = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        rb.useGravity = true;
        mouseReleasePos = Input.mousePosition;
        Shoot(mouseReleasePos - mousePressDownPos);
    }

    private float forceMultiplier = 3;
    void Shoot(Vector3 Force)
    {
        if (isShoot)
            return;

        rb.AddForce(new Vector3(Force.x, Force.y, Force.y) * forceMultiplier);
        isShoot = true;
    }

    public bool IsShot()
    {
        return isShoot;
    }

    public void SetShotState(bool state)
    {
        isShoot = state;
    }

    private void OnTriggerEnter(Collider target)
    {
        if(target.tag == "Target")
        {
            score += 10;
            ScoreController.Instance.SetScoreText(score);
        }
    }
}