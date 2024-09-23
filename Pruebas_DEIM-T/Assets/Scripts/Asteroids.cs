using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    // VARIABLES
    //Vidas
    int lifes;
    float shield;
    bool alive;

    //Variables de inicio
    int initLifes = 10;
    float initShield = 100f;


    //Rango aleatorio de daño
    public float maxDamage = 100f;
    public float minDamage = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();

        
    }

    // Update is called once per frame
    void Update()
    {
        DetectarImpacto();

        if(Input.GetKeyDown(KeyCode.Return) && alive == false)
        {
            StartGame();
        }
    }

    void StartGame()
    {
        lifes = initLifes;
        alive = true;
        shield = initShield;
    }

    void DetectarImpacto()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive)
        {
            Impacto();

        }
        
    }


    void Impacto()
    {

        float damage = CalculateDamage();
        shield -= damage;
        print("Me han impactado con un daño de " + damage);
        if(shield < 0)
        {
            RestarVida();

        }
        else
        {
            print("Te queda " + shield + " de escudo"); 
        }
    }

    void RestarVida()
    {
        lifes--;
        if(lifes <= 0)
        {
            Die();
        }
        else
        {
            shield = 100f;
            print("Te han matado. Te quedan " + lifes + " vidas");
            BuclePorLaVida();
            

        }
    }

    void BuclePorLaVida()
    {
        for (int i = 0; i < lifes; i++)
        {
            print("Bucle por la vida " + i);
        }
    }

    float CalculateDamage()
    {
        //Calculo un daño aleatorio
        float damage = Random.Range(minDamage, maxDamage);
        //Redondeo el daño para que no tenga decimales
        damage = Mathf.Round(damage);

        return damage;
    }

    void Die()
    {
        alive = false;
        print("Estás muerto. Pulsa Enter para empezar a jugar.");
    }


}
