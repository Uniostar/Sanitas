using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    //Text Outputs
    public Text sleepText, heartDataText, heartRateRatingText, spo2Text, bmiValueText, bmiPropertyText, bmiRateText, healthRating;

    //Inputs
    public InputField ageInput, pulseInput, spo2Input, heightInput, weightInput, sleepInput;

    //Checkmarks
    public Toggle heart, kidney, asthama, sleepDisorders;

    //Scenes
    public GameObject scene1;
    public GameObject scene2;
    public GameObject scene3;

    //Identifiers needed for calculating health rating
    float age, heartRate, spo2, height, weight, sleep, BMI;
    float heartRateRating, SPO2Rating, BMIRate, sleep_time_Rating;

    //Set Up Scene  1
    void Start()
    {
        scene1.SetActive(true);
        scene2.SetActive(false);
        scene3.SetActive(false);
    }
    //Switch to Scene 2
    public void GoToScene2()
    {
        scene1.SetActive(false);
        scene2.SetActive(true);
        scene3.SetActive(false);
    }

    //Switch to Scene 3
    public void GoToScene3()
    {
        //Convert Input String to Float
        age = float.Parse(ageInput.text);
        heartRate = float.Parse(pulseInput.text);
        spo2 = float.Parse(spo2Input.text);
        height = float.Parse(heightInput.text);
        weight = float.Parse(weightInput.text);
        sleep = float.Parse(sleepInput.text);

        //Open Scene 3
        scene1.SetActive(false);
        scene2.SetActive(false);
        scene3.SetActive(true);

        //If Sleep Disorders is Checked
        if (sleepDisorders.isOn)
        {
            //If sleep time is greater than 9 hours
            if (sleep > 9)
            {
                sleepText.text = "> Please visit a sleep specialist, because you might have hypersomia!";
                sleep_time_Rating = 10;
            }
            //If sleep time is between 9 and 7 hours
            if ((sleep < 9) && (sleep > 7))
            {
                sleepText.text = "> You have a healthy sleep schedule!";
                sleep_time_Rating = 10;
            }
            //If sleep time is under 7 hours
            if (sleep < 7)
            {
                sleepText.text = "> You need to work on your sleep schedule";
                sleep_time_Rating = (8 - sleep) * 125 / 100;
            }
        }
        //If Sleep Disorders is Unchecked
        else
        {
            //If sleep time is greater than 9 hours
            if (sleep > 9)
            {
                sleepText.text = ("> Your sleep shoes no problems!");
                sleep_time_Rating = 10;
            }
            //If sleep time is between 9 and 7 hours
            if ((sleep < 9) && (sleep > 7))
            {
                sleepText.text = "> You have a healthy sleep schedule!";
                sleep_time_Rating = 10;
            }
            //If sleep time is under 7 hours
            if (sleep < 7)
            {
                sleepText.text = "> You need to work on your sleep schedule";
                sleep_time_Rating = (8 - sleep) * 125 / 100;
            }

        }
        //If Age is greater than 18
        if (age > 18)
        {
            //If heart rate is greater than 90
            if (heartRate > 90)
            {
                heartDataText.text = ("> Heart rate too high. Consult a doctor. Do deep breaths, exercise well, and maintain a healthy diet reducing coffee consumption. Don't panic if you are stressed, everything will be fine.");
                float heartRateDev = (heartRate - 110) / 10;
                heartRateRating = 8 - heartRateDev;
            }
            //If Heart rate is less than 60
            else if (heartRate < 60)
            {
                heartDataText.text = ("> Heart rate too low. Consult a doctor");
                float heartRateDev = (60 - heartRate) / 10;
                heartRateRating = 8 - heartRateDev;
            }
            //If heart rate is between 90 and 60
            else
            {
                heartDataText.text = ("> Heart rate is healthy");
                float heartRateDev = (Mathf.Abs(heartRate - 85)) / 10;
                heartRateRating = 10 - heartRateDev;
            }
        }
        //If age is under or equal to 18
        else
        {
            //If heart rate is greater than 120
            if (heartRate > 120)
            {
                heartDataText.text = ("> Heart rate too high. Consult a doctor. Do deep breaths and maintain a healthy diet. Don't panic if you are stressed, everything will be fine.");
                float heartRateDev = (heartRate - 110) / 10;
                heartRateRating = 8 - heartRateDev;
            }
            //If heart rate is less than 50
            else if (heartRate < 50)
            {
                heartDataText.text = ("> Heart rate too low. Consult a doctor.");
                float heartRateDev = (50 - heartRate) / 10;
                heartRateRating = 8 - heartRateDev;
            }
            //If heart rate is between 120 and 50
            else
            {
                heartDataText.text = ("> Heart rate is healthy");
                float heartRateDev = (Mathf.Abs(heartRate - 85)) / 10;
                heartRateRating = 10 - heartRateDev;
            }
        }

        //Calculate Heart Rate Rating and Print It
        heartRateRatingText.text = ("> Heart Rate Rating : " + heartRateRating.ToString());

        //Calculate SpO2 Rating
        SPO2Rating = (spo2 - 80) / 2;

        //If SPO2 is lesser than or equal to 94
        if (spo2 <= 94)
        {
            spo2Text.text = ("> Your oxygen level is low. Consult a doctor. " + SPO2Rating + " is your SpO2 Rating.");
        }
        //If SpO2 is greater than 94
        else
        {
            spo2Text.text = ("> Your oxygen levels are healthy " + SPO2Rating + " is your SpO2 Rating.");
        }

        //Find and print BMI
        BMI = weight / (Mathf.Pow((height / 100), 2));
        bmiValueText.text = ("> Your BMI is " + BMI + " kg/m²");

        //If age is greater than 20
        if (age > 20)
        {
            //If BMI is greater than and equal to 25
            if (BMI >= 25.0)
            {
                bmiPropertyText.text = ("> Your BMI is higher than recommended levels");
                float BMIDev = BMI - 25;
                BMIRate = 8 - BMIDev;
            }
            //If BMI is between 24.9 and 18.5
            if ((BMI < 24.9) && (BMI > 18.5))
            {
                bmiPropertyText.text = ("> You have a healthy BMI");
                float BMIDev = Mathf.Abs(BMI - 21.7f);
                BMIRate = 10 - BMIDev;
            }
            //If BMI is lesser than 18.5
            if (BMI < 18.5)
            {
                bmiPropertyText.text = ("> Your BMI is lower than recommended levels");
                float BMIDev = 18.5f - BMI;
                BMIRate = 8 - BMIDev;
            }
        }
        //If age is smaller than equal to 20
        if (age <= 20)
        {
            //If Age is between 2 and 10
            if (age >= 2 && age <= 10)
            {
                //If BMI is less than 14
                if (BMI < 14)
                {
                    bmiPropertyText.text = ("> Your BMI is lower than recommended levels");
                    float BMIDev = 14 - BMI;
                    BMIRate = 8 - BMIDev;
                }
                //If BMI is greater than 18
                else if (BMI > 18)
                {
                    bmiPropertyText.text = ("> Your BMI is higher than recommended levels");
                    float BMIDev = BMI - 18;
                    BMIRate = 8 - BMIDev;
                }
                //If BMI is between 18 and 14
                else
                {
                    bmiPropertyText.text = ("> You have a healthy BMI");
                    float BMIDev = Mathf.Abs(BMI - 16);
                    BMIRate = 10 - BMIDev;
                }
            }
            //If Age is between 11 and 14
            if (age >= 11 && age <= 14)
            {
                //If BMI is lesser than 14.5
                if (BMI < 14.5)
                {
                    bmiPropertyText.text = ("> Your BMI is lower than recommended levels");
                    float BMIDev = 14.5f - BMI;
                    BMIRate = 8 - BMIDev;
                }
                //If BMI is greater than 22
                else if (BMI > 22)
                {
                    bmiPropertyText.text = ("> Your BMI is higher than recommended levels");
                    float BMIDev = BMI - 22;
                    BMIRate = 8 - BMIDev;
                }
                //If BMI is between 22 and 14.5
                else
                {
                    bmiPropertyText.text = ("> You have a healthy BMI");
                    float BMIDev = Mathf.Abs(BMI - 18.25f);
                    BMIRate = 10 - BMIDev;
                }
            }
            //If age is between 14 and 20
            if (age > 14 && age <= 20)
            {
                //If BMI is lesser than 17
                if (BMI < 17)
                {
                    bmiPropertyText.text = ("> Your BMI is lower than recommended levels");
                    float BMIDev = 17 - BMI;
                    BMIRate = 8 - BMIDev;
                }
                //If BMI greater than 26
                else if (BMI > 26)
                {
                    bmiPropertyText.text = ("> Your BMI is higher than recommended levels");
                    float BMIDev = BMI - 26;
                    BMIRate = 8 - BMIDev;
                }
                //If BMI is between 26 and 17
                else
                {
                    bmiPropertyText.text = ("> You have a healthy BMI");
                    float BMIDev = Mathf.Abs(BMI - 21.5f);
                    BMIRate = 8 - BMIDev;
                }
            }
        }

        //Claculate BMI Rating
        bmiRateText.text = ("> Your BMI Rating is - " + BMIRate.ToString());

        //Calculate Health Rate Index
        healthRating.text = "> Health Rate Index : " + (((SPO2Rating) + (heartRateRating) + (BMIRate) + (sleep_time_Rating)) / 4).ToString();
    }
    public void TestEyeSight()
    {
        Application.OpenURL("https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Snellen_chart.svg/800px-Snellen_chart.svg.png");
    }
}