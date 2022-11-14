using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class Coroutine : MonoBehaviour
{
    Rigidbody tankrb;
    bool isRunning;
    float yRotation;
    public float speed;

    void Start()
    {
        tankrb = GetComponent<Rigidbody>();
        StartCoroutine(myCoroutine());

        yRotation = 0f;
    }

    IEnumerator myCoroutine()
    {
        for (int i = 0; i < 75; i++)
        {
            tankrb.AddForce(transform.forward * speed, ForceMode.Impulse);
            yield return new WaitForSeconds(2f);

            yRotation = 0.3f;
            yield return new WaitForSeconds(2);
            yRotation = 0f;

            tankrb.AddForce(-transform.forward * speed, ForceMode.Impulse);
            yield return new WaitForSeconds(2f);
        }
    }

    private void Update()
    {
        transform.Rotate(0, yRotation, 0);
    }
}



