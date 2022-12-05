using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanti : MonoBehaviour
{
 
    public GameObject[] puntofan;//se declara la variable ene

    private float timeBtwSpawn;//el tiempo en que empieza
    public float startTimeBtwSpawn;//funcion que declara el tiempo en que empieza
    public float decreseTime;//reduce el tiempo de inicio del fantasma
    public float minTime = 0.65f;//
   
    private void Update()
    {
        if (timeBtwSpawn <= 0)//checa el tiempo en que empieza
        {
            int rand = Random.Range(0,puntofan.Length);
            Instantiate(puntofan[rand], transform.position, Quaternion.identity);//inicializa a enemigo en la posicion transform y no tiene rotacion 
            timeBtwSpawn = startTimeBtwSpawn;//es igual al tiempo de inicio del fantasma
            if(startTimeBtwSpawn > minTime){
                startTimeBtwSpawn -= decreseTime;

            }
        }
        else {
            timeBtwSpawn -= Time.deltaTime;//sino decrese el tiempo de espera
        }
    }
}
