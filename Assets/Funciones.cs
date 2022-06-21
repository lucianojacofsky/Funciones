using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Funciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Holamundo();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
           CadenaEnConsola("Argumento");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(RetornaRandomEntre(-1, 11));
        }
    }
    public void destruirObjeto()
    {
        Destroy(gameObject);
    }
    void Holamundo()
    {
        Debug.Log("Hola Mundo");
    }
    void CadenaEnConsola(string cadena)
    {
        Debug.Log(cadena);
    }
    string RetornaAlgo()
    {
        return ("Algo");
    }
    int RetornaRandomEntre(int n1, int n2)
    {
        if (n1 >= 0 && n2>0)
        {
            return Random.Range(n1, n2);
        }
        else
        {
            return -1;
        }
        
    }
    string RetornarMayor(int n1, int n2, int n3)
    {
        if (n1>n2 && n1 > n3)
        {
            string s1 = n1.ToString();
            return s1;
        } else if (n2>n1 && n2>n3)
        {
            string s2 = n2.ToString();
            return s2;
        }
        else if (n3 < n1 && n3 > n2)
        {
            string s3 = n3.ToString();
            return s3;
        }
    }
}
