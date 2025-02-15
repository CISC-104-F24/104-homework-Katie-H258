using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GooseCardMaker : MonoBehaviour
{
    public Image gooseBase;
    public float silliness;
    public float fanciness;
    public float power;
   
    public bool grassOn = true;
    
    public Button hatLeft;
    public Button hatRight;
    public Button neckLeft;
    public Button neckRight;
    public Button shoes;
    public Button randomize;
    
    public GameObject kingCrown;
    public GameObject queenCrown;
    public GameObject jesterHat;
    public GameObject partyHat;
    public GameObject propellerHat;

    public GameObject blueBow;
    public GameObject bowtie;
    public GameObject flower;
    public GameObject heart;
    public GameObject necktie;

    public GameObject galoshes;
    public GameObject slippers;
    public GameObject sneakers;

    public GameObject knife;
   
    public int hatNumber;
    public int tieNumber;
    public int shoeNumber;
    public int knifeChance;

    // Start is called before the first frame update
    void Start()
    {
        hatNumber = 0;
        tieNumber = 0;
        shoeNumber = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //set all variables below, follow suit of crown already there
        kingCrown.SetActive(false);
        bool is_Kcrown_Active = hatNumber == 1;
        if (is_Kcrown_Active) 
        { kingCrown.SetActive(true); }

        queenCrown.SetActive(false);
        bool is_Qcrown_Active = hatNumber == 2;
        if (is_Qcrown_Active)
        { queenCrown.SetActive(true); }

        jesterHat.SetActive(false);
        bool is_Jhat_Active = hatNumber == 3;
        if (is_Jhat_Active)
        { jesterHat.SetActive(true); }

        partyHat.SetActive(false);
        bool is_PartyHat_Active = hatNumber == 4;
        if (is_PartyHat_Active)
        { partyHat.SetActive(true); }

        propellerHat.SetActive(false);
        bool is_Propeller_Active = hatNumber == 5;
        if (is_Propeller_Active)
        { propellerHat.SetActive(true); }


        blueBow.SetActive(false);
        bool is_BlueBow_Active = tieNumber == 1;
        if (is_BlueBow_Active)
        { blueBow.SetActive(true); }

        bowtie.SetActive(false);
        bool is_Bowtie_Active = tieNumber == 2;
        if (is_Bowtie_Active)
        { bowtie.SetActive(true); }

        flower.SetActive(false);
        bool is_Flower_Active = tieNumber == 3;
        if (is_Flower_Active)
        { flower.SetActive(true); }

        heart.SetActive(false);
        bool is_Heart_Active = tieNumber == 4;
        if (is_Heart_Active)
        { heart.SetActive(true); }

        necktie.SetActive(false);
        bool is_Necktie_Active = tieNumber == 5;
        if (is_Necktie_Active)
        { necktie.SetActive(true); }


        galoshes.SetActive(false);
        bool is_Galoshes_Active = shoeNumber == 1;
        if (is_Galoshes_Active)
        { galoshes.SetActive(true); }

        slippers.SetActive(false);
        bool is_Slippers_Active = shoeNumber == 2;
        if (is_Slippers_Active)
        { slippers.SetActive(true); }

        sneakers.SetActive(false);
        bool is_Sneakers_Active = shoeNumber == 3;
        if (is_Sneakers_Active)
        { sneakers.SetActive(true); }

    }
    // make a function for each button like the randomizer button 
    public void Randomizer() 
    {
        hatNumber = Random.Range(0, 6);
        tieNumber = Random.Range(0, 6);
        shoeNumber = Random.Range(0, 4); 

        knifeChance = Random.Range(0, 101);
        if (knifeChance <= 20)
        {
            knife.SetActive(true);
        }
        else
        {
            knife.SetActive(false);
        }
    }

    public void hatChanger()
    {
     
    }

}
