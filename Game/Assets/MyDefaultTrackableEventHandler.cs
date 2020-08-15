using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class MyDefaultTrackableEventHandler : DefaultTrackableEventHandler
{
    public GameObject Manejador;
    public Text nombre;
    public Text data;

    protected override void Start(){
        base.Start();
    }

    protected override void OnTrackingFound(){
        Manejador.GetComponent<Manejador>().Add(base.mTrackableBehaviour.TrackableName);
        this.nombre.text = base.mTrackableBehaviour.TrackableName;
        this.data.text = "Damage: "+(PokemonData.getData(base.mTrackableBehaviour.TrackableName));
        base.OnTrackingFound ();
    }

    protected override void OnTrackingLost(){
        Manejador.GetComponent<Manejador>().Remove(base.mTrackableBehaviour.TrackableName);
        base.OnTrackingLost ();
    }
}