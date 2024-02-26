using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>

public class Entorno : MonoBehaviour
{
    #region 1)Definicion de variables
    public float velocidad;
    #endregion

    #region 2)Funciones predeterminadas Unity
    void Awake()
    {
        
    }
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.back * velocidad * Time.deltaTime, Space.World);
    }




    #endregion

    #region 3)Metodos originales

    #endregion
}
