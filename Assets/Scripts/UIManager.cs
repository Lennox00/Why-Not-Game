﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Image[] vidasImage;
    public Image barraEnergiaEmpty;
    public Image barraEnergia;
    float barraEnergiaWidthfull;
    int vidasActuales;



    void Awake()
    {
        barraEnergiaEmpty.color = Style.GetColor(Style.barraEnergiaEmpty);
        barraEnergia.color = Style.GetColor(Style.barraEnergiaFull);
        barraEnergiaWidthfull = barraEnergiaEmpty.rectTransform.sizeDelta.x;

        ActualizarVidas();
        ActualizarEnergia();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ActualizarVidas(int vidas = 0) {        
        foreach (Image vida in vidasImage) {
            vida.color = Style.GetColor(Style.vidaEmpty);
        }
        for (int i = 0; i < vidas; i++) {
            vidasImage[i].color = Style.GetColor(Style.vidaFull);
        }
    }

    public void ActualizarEnergia(int energia = 0) {
        RectTransform rectTransform = barraEnergia.rectTransform;
        float width = (barraEnergiaWidthfull / 15) * energia;
        rectTransform.sizeDelta = new Vector2(width, rectTransform.sizeDelta.y);
    }
}
