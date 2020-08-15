using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonData : MonoBehaviour
{
    static int BlastoiseDamage = 150;
    static int CharizardDamage = 130;
    static int IvysaurDamage = 60;
    static int MetapodDamage = 30;
    static int PidgeyDamage = 20;
    static int PikachuDamage = 10;


    public static int getData(string name){
        switch(name){
            case "Blastoise": 
                return BlastoiseDamage; 
                break;
            case "Charizard": 
                return CharizardDamage; 
                break;
            case "Ivysaur": 
                return IvysaurDamage; 
                break;
            case "Metapod": 
                return MetapodDamage; 
                break;
            case "Pidgey": 
                return PidgeyDamage; 
                break;
            case "Pikachu": 
                return PikachuDamage; 
                break;
            default: return 0;
        }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
