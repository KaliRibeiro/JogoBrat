using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bola : MonoBehaviour
{

    Vector2 direcao;
    int rapidez, pontos, vidas;

   public TextMeshProUGUI txtVidas, txtPontos;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direcao = Vector2.one.normalized;
        rapidez = 4;
        pontos=0;
        vidas =3;

        //inicia os valores no text

        txtVidas.text = vidas.ToString();
        txtPontos.text = pontos.ToString();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
rb.velocity = direcao*rapidez;
        
    }

   void OnCollisionEnter2D(Collision2D c){
    //o c é o elemento q colidiu com bola
    
    string tag = c.gameObject.tag;

    if(tag.Equals("cima") || tag.Equals("baixo")) {

        direcao.y = direcao.y * -1;
    } else if(tag.Equals("direita")){

        direcao.x = direcao.x * -1;

    } else if(tag.Equals("jogador")){

        direcao.x = direcao.x * -1;
        pontos++;
        txtPontos.text = pontos.ToString();

    }else if(tag.Equals("esquerda")){

        direcao.x = direcao.x * -1;
        vidas--;
        txtVidas.text = vidas.ToString();

        //bola no meio

        this.transform.position = new Vector3(0,0);
    }
}
}
