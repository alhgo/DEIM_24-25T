using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int lifes = 3;
    float shield = 1f;

    bool isAtacking = false;

    //Velocidad de desplazamiento
    float speed = 0f;

    string name = "Pepe";

    //Estoy tocando suelo?
    bool isGrounded = true;

    bool powerUp = false;


    private void Start()
    {
       // name = "Paco";
        //EjecutarBucle();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            EjecutarBucle();
        }
    }


    void EjecutarBucle()
    {

        for(int i = 0; i < lifes;  i++)
        {
            print("Vida " + i );
        }

        /*
        int n = 0;
        while(n < 10)
        {
            print(n);
            n = n + 1;

        }
        */
    }


    /*
    void Atacar()
    {
      
    }

    void Jump()
    {
        if (isAtacking == false && isGrounded == true)
        {
            print("salto");
        }
        else if(powerUp == true)
        {
            print("Salto con power up");
        }
        else 
        {
            print("No puedes saltar");
        }
    }

    float Sumar(float num1, float num2)
    {
        float resultado = num1 + num2;
        return resultado;   
    }

    void moverse()
    {
        print("Me estoy moviendo a una velocidad de " + speed);
    }
    */

}
