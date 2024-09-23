using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarshipController : MonoBehaviour
{
    Vector3 initPos = new Vector3(0f, 2f, 0f);
    Vector3 initScale = Vector3.forward * 2;

    public float speed;
    float rotationSpeed = 1f;

    float move;
    float moveL;
    float rotation;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = initPos;
        transform.localScale = Vector3.one;
        transform.rotation = Quaternion.Euler(0f, 0f, 45f);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Shoot();
        }

        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }


        move = Input.GetAxis("Vertical");
        moveL = Input.GetAxis("Horizontal");
        rotation = Input.GetAxis("Rotar");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * move);
        transform.Translate(Vector3.right * Time.deltaTime * speed * moveL, Space.World);
        transform.Rotate(Vector3.forward * -rotation * Time.deltaTime * rotationSpeed * 360f );
    }

    void Shoot()
    {
        print("PUM");
    }
}
