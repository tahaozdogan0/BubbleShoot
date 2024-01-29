using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunKontrolcu : MonoBehaviour
{
    public UnityEngine.UI.Text zamanText, balonText;
    public float zamanSayaci = 60;
    public GameObject patlama;
    int patlayanBalon = 0;
    
    
    void Start()
    {
        balonText.text = "Balon : " + patlayanBalon;
    }


    void Update()
    {
        if (zamanSayaci > 0)
        {
            zamanSayaci -= Time.deltaTime;
            zamanText.text = "S�re : " + (int)zamanSayaci;
        }
        
        else
        {
            SceneManager.LoadScene("Kapan�sMenu");
        }
    }

    public void BalonEkle()
    {
        patlayanBalon += 1;
        balonText.text = "Balon : " + patlayanBalon;
    }
}
