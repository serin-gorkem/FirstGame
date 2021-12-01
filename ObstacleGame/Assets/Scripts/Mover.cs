using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]float moveSpeed=10f;
    void Start()
    {
        TutorialPrint();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void TutorialPrint()
    {
        Debug.Log("Welcome To The Game.");
        Debug.Log("Use directional keys or WASD to navigate.");
        Debug.Log("Get to the targeted location");
    }

    void Move()
    {
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;
        zValue = zValue*moveSpeed;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        xValue = xValue*moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
