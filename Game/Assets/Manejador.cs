using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manejador : MonoBehaviour{

    public Text juego;
    public Text gano;

    private bool gameOn = false;

    public int space = 3;
    public List<string> pokemon = new List<string>();

    public void Show(string test){
        Debug.Log(test);
    }

    public void Add(string name){
        if(pokemon.Count < space){
            pokemon.Add(name);
        }else{
            //Debug.LogWarning("Espacio insuficiente");
        }
    }

    public void Remove(string name){
        if(pokemon.Contains(name)){
            pokemon.Remove(name);
        }else{
            //Debug.LogWarning("No se encontro pokemon");
        }
    }

    void InicarJuego(){
        gameOn = true;
        Debug.Log("iniciar Juego");
        juego.GetComponent<Text>().enabled = true;
        gano.GetComponent<Text>().enabled = true;

        int p1 = PokemonData.getData(pokemon[0]);
        int p2 = PokemonData.getData(pokemon[1]);

        if(p1>p2){
            gano.text = "Ganador: "+pokemon[0];
        }else if(p2>p1){
            gano.text = "Ganador: "+pokemon[1];
        }else{
            gano.text = "Empate"; 
        }
    }

    void TerminarJuego(){
       gameOn = false;
       juego.GetComponent<Text>().enabled = false;
       gano.GetComponent<Text>().enabled = false;

    }


    // Start is called before the first frame update
    void Start()
    {
        juego.GetComponent<Text>().enabled = false;
        gano.GetComponent<Text>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pokemon.Count>=2){
            if(!gameOn)
                InicarJuego();
        }else{
            if(gameOn)
                TerminarJuego();
        }
    }
}
