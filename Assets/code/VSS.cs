using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;

public class VSS : MonoBehaviour
{
    public int Ochko;
    public Text Pervoechislo;
    public Text Vtoroechislo;
    public Text Tretoechislo;
    int randomX;
    int randomY;
    int randomZ;
    
    void Start()
    {
        
        
       int randomX = Random.Range(1, 10);
       Pervoechislo.text = randomX.ToString();
       int randomY = Random.Range(1, 10);
       Vtoroechislo.text = randomY.ToString();
       int randomZ = Random.Range(1, 10);
       Tretoechislo.text = randomZ.ToString(); 
 
    }

    void UX() { 
        


    }

    
    void Update()
    {
        
    }

}
