using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coletaritens : MonoBehaviour
{
    public Text pontuacao;
    private int pontos;
    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
        pontuacao.text = "Score: " + pontos;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "estatua")
        {
            other.gameObject.SetActive(false);
            pontos = pontos + 1;
            pontuacao.text = "Score: " + pontos;
        }
    }
}
