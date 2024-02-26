using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>

public class MiPersonaje : MonoBehaviour
{
    #region 1)Definicion de variables

    Rigidbody rb;

    [SerializeField] float alturaMax;
    Carril carril;
    #endregion

    #region 2)Funciones predeterminadas Unity
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Saltar();
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            if (carril == Carril.Derecho){
                EstablecerCarril(Carril.Central);
            }
            else if (carril == Carril.Central) {
                EstablecerCarril(Carril.Izquierdo);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (carril == Carril.Izquierdo)
            {
                EstablecerCarril(Carril.Central);
            }
            else if (carril == Carril.Central)
            {
                EstablecerCarril(Carril.Derecho);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstaculos"))
        {
            Debug.Log("Personajes choca con obstaculo");
        }
    }
    #endregion

    #region 3)Metodos originales

    void Saltar() { 
        rb.velocity = Vector3.zero;

        float _fuerzaSalto = Mathf.Sqrt(alturaMax * -2f * Physics.gravity.y * rb.mass);

    }
    void EstablecerCarril(Carril nuevoCarril) {
        Carril carrilAnterior = carril;
        carril = nuevoCarril;
        switch (carril)
        {
            case Carril.Izquierdo:
                MoverHacia(-1);
                break;
            case Carril.Central:
                if (carrilAnterior == Carril.Izquierdo)
                {
                    MoverHacia(1);
                }
                else if (carrilAnterior == Carril.Derecho) {
                    MoverHacia(-1);
                }
                break;
            case Carril.Derecho:
                MoverHacia(1);
                break;
        }

    }
    //Mueve el personaje a la izquierda o derecha dependiendo de si direccion es -1 o 1
    void MoverHacia(int direccion) { 
        //TODO: hacer movimiento

    }

    #endregion

    enum Carril { 
        Izquierdo,
        Central,
        Derecho
    }
}
