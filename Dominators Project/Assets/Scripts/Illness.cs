using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Illness : MonoBehaviour
{
    public Text Symptoms, diseaseInfo;
    public Button decline, accept;
    int index = 0;

    public void Start()
    {
        KidProb();
        Symptoms.gameObject.SetActive(true);
        diseaseInfo.gameObject.SetActive(false);
        decline.interactable = true;
        accept.interactable = true;
    }
    public void Update()
    {
        switch (index)
        {
            case 0:
                break;
            case 1:
                Flu();
                break;
            case 2:
                EarInfection();
                break;
            case 3:
                Sinusitis();
                break;
            case 4:
                Covid();
                break;
            default:
                Symptoms.text = "If you have any symptoms, please consult a doctor who can tend to them";
                decline.interactable = false;
                accept.interactable = false;
                break;
        }
    }
    public void Back()
    {
        SceneManager.LoadScene(1);
    }
    public void Accepted()
    {
        Symptoms.gameObject.SetActive(false);
        diseaseInfo.gameObject.SetActive(true);
        decline.interactable = false;
        accept.interactable = false;
    }
    public void Declined()
    {
        index++;
    }
    public void KidProb()
    {

        Symptoms.text = (@"Do you have any of the following symptoms?
                         1. kidney damage, insufficient urine production, kidney failure, severe
                            unintentional weight loss
                         2. fatigue or loss of appetite
                         3. high blood pressure, abnormal heart rhythm, fluid in the lungs");

        diseaseInfo.text = (@"It is likely you have kidney disease
                            Diabetes, High blood pressure, Inflammation of parts of the kidney, and other kidney infections can cause this. Consult a doctor for kidney disease testing etc., don't smoke and maintain a healthy weight to prevent this.");
    }
    public void Flu()
    {
        Symptoms.text = (@"Do you have any of the following symptoms?
                         1. High fever and shortness of breath
                         2. Headache and muscle fatigue
                         3. Dry cough and sore throat");

        diseaseInfo.text = (@"It is most likely you have the flu (influenza) or the common cold
                            It is caused by the influenza virus (flu) or other viruses (common cold). Drink more water and other fluids and keep your body hydrated. To prevent such diseases, vaccinate yourself regularly");
    }
    public void EarInfection()
    {
        Symptoms.text = (@"Do you have any of the following symptoms?
                         1. Pain in the ear
                         2. fever, loss of appetite, or vertigo
                         3. inflammation of the ear or hearing difficulty");

        diseaseInfo.text = (@"It is likely you have ear infection
                            usually caused by bacteria or viruses. Most ear infections go away on their own. Some require antibiotics. To prevent such diseases, keep away from allergens, maintain distance from those with respiratory diseases. Do vaccinate yourself regularly.");
    }
    public void Sinusitis()
    {
        Symptoms.text = (@"Do you have any of the following symptoms?
 			             1. Pain in the face, sinuses, back of the eyes, ear, or forehead
		            	 2. fever, headache, fatigue or facial swelling
			             3. nasal congestion, smelling issues, runny nose, sneezing");
        diseaseInfo.text = (@"It is likely you have sinusitis (sinus infections)
			                 Acute sinusitis can be triggered by a cold or allergies and may resolve on its own. It usually doesn't require any treatment beyond symptomatic relief. Chronic sinusitis may require antibiotics. To prevent such diseases, keep away from allergens, reduce smoking and maintain distance from those with respiratory diseases. Do vaccinate yourself regularly.");
    }
    public void Covid()
    {
        Symptoms.text = (@"Do you have any of the following symptoms?
                         1. sore throat, headache, aches and pains, diarrhoea
		                 2. difficulty breathing or shortness of breath, chest pain, fever,
                            cough
		                 3. loss of speech or mobility, or confusion");
        diseaseInfo.text = (@"It is most likely you have the coronavirus Covid-19
				            It is caused by the coronavirus. Wear a mask, Clean your hands, Maintain safe distance, Get vaccinated to prevent the spread of the disease. Isolate yourself in a well ventilated room. Use and discard your mask appropriately. Take rest and drink a lot of fluids. Follow respiratory etiquettes. Frequently sanitize hands, surfaces and substances. Don’t share personal items with other people in the household. Monitor temperature and SPO2. Connect with physician if symptom is noticed.");
    }
}
