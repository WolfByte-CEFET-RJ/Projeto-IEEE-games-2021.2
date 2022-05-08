using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempoJokenpo : MonoBehaviour
{
    //Script para liberar os jogadores de jogarem o Jokenpo de 6 em 6 segundos

    int tempoInt, j;
    [HideInInspector]
    public int count = 0;
    float temporizador;
    [HideInInspector]
    public bool jogo = false;   //Rodrigo --> Variável jogo precisa ser pública para ser utiliizada em outros scritps, "[HideInInspector]" utilizado para escondê-la como se fosse privada
    public Text tempTxt;


    void Start()
    {
        temporizador = 0;
        j = 0;
    }
    
    void Update()
    {
        //Rodrigo --> Atualizando a variável temporizador/contabilizando a passagem de tempo
        temporizador += Time.deltaTime;

        //Rodrigo --> Atribuindo o valor de tempo a uma variável inteira
        tempoInt = (int)temporizador;

        //Felipe --> Joga o valor do temporizador para uma UI de texto na cena do jogo
        tempTxt.text = tempoInt.ToString();

        //Rodrigo --> if para realizar o jokenpo de 6 em 6 segundos (modificar o número dividindo tempoInt para mudar o intervalo de tempo)
        if(tempoInt > 6  && tempoInt != 0)
        {
            temporizador = 1;           // Felipe --> troca o valor do temporizador para 1 ao final de cada partida

            for(int i = j; j < 1; i++)  //Rodrigo --> for que limita o for a uma vez usando o valor de j
            {
                //Debug.Log("TempoJokenpo funcionando.");
                jogo = true;
                j = 1;
            }
        }
        else    //Rodrigo --> else para resetar o valor de j
        {
            jogo = false;
            j = 0;
        }
    }
}
