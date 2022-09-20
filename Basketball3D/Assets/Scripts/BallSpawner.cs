using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public ShootBall ballObject;
    
    void Update()
    {
        if(ballObject.IsShot())
        {
            StartCoroutine(WaitforSomeTime());
        }
    }

    IEnumerator WaitforSomeTime()
    {
        ballObject.SetShotState(false);
        yield return new WaitForSeconds(3f);
        ballObject.gameObject.SetActive(false);
        ballObject.gameObject.transform.position = new Vector3(0.02f, 0.44f, -7.49f);
        ballObject.gameObject.SetActive(true);
        ballObject.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ballObject.gameObject.GetComponent<Rigidbody>().useGravity = false;
    }
}
