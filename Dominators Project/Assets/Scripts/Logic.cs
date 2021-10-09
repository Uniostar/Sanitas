using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public Text sleepText, heartDataText, heartRateRatingText, spo2Text, bmiValueText, bmiPropertyText, bmiRateText, healthRating;
    public InputField ageInput, pulseInput, spo2Input, heightInput, weightInput, sleepInput;
    public Toggle heart, kidney, asthama, sleepDisorders;

    public GameObject scene1;
    public GameObject scene2;
    public GameObject scene3;

    string[] info;
    float age, heartRate, spo2, height, weight, sleep, BMI;
    float heartRateRating, SPO2Rating, BMIRate, sleep_time_Rating;

    void Start()
    {
        scene1.SetActive(true);
        scene2.SetActive(false);
        scene3.SetActive(false);
    }
    void Update()
    {
        /*print("Your sleep is one of the most important parts of your health. If you are facing issues with your sleep that regular interruptions and tiredness throughout the day, you may be suffering from diseases like sleep apnea or Hyposomnia.");
        print("Hyposomnia is a dangerous disease that causes you to fall into small bouts of sleep called microsleeps that shuts down your bodies for small periods. This can be fatal, like when you are driving a car, or walking down stairs");
        print("Sleep Apnea is a disease in which your breathing repearedly stops and starts int he middle of the night. This disease is fatal and many times needs surgery");
        print("If you have any of the following symptoms, or identify as having any of the following conditions, contact a doctor immediately");
        */

        //Put it separately in the app print(heartRateRating + " is the rating of how good your heart rate is from the average out of 10, 10 being the best heart rate, 0 being the worst");

        /*Put it separately in the app - Pend.text += "Importance of the heart rate");
        end.text += ("A high heart rate normally means that you are either very panicked or are having any heart issues. Many times this can be because of Arrhythmia, a disease in which your heart beats irregularly. This might also be because you have a viral infection or something else that is affecting your body. ");
        end.text += ("A slow heart rate can cause you to feel fatigued and sometimes be a sign of impendent Cardiac Arrest. ");*/

        /* Place it separately end.text += (SPO2Rating + " is the rating of how good your SPO2 is from the average out of 10, 10 being the best Blood saturation, 0 being the worst");
        end.text += ("Your SpO2 Rating determines the saaturation of oxygen in your body. Any saturation below 94 is unhealthy and a saturation below 85 leaves you unconscious. This is one of the most important Health factors, make sure to keep it normal and healthy based on instructions we will give later on.");
        */

        /*print(BMIRate + " BMIRate is the rating of how good your Body Mass Index is from the average out of 10, 10 being the best Body Mass Index, 0 being the worst");
        print("Your BMI is the ratio of your mass to height and determines whether you are under or over-weight.");
        */

        //end.text += ("Heart Rate Rating is the rating of how good your heart rate is from the average out of 10, 10 being the best heart rate, 0 being the worst");

        /*System.out.println("your oxygen saturation is the most important part of your health, if it goes too low, it can even be fatal");
        System.out.println("Your Heart rate determines a very large part of your health. Maintaining a regular and healthy heart rate is very important");
        System.out.println("Your Sleep and BMI determine your health in your day-today life. Despite not being as important as the heart rate and Oxygen saturation, they must still be well maintained, as in the long term this can lead to health problems");
        */
    }
    public void GoToScene2()
    {
        scene1.SetActive(false);
        scene2.SetActive(true);
        scene3.SetActive(false);
    }
    public void GoToScene3()
    {
        age = float.Parse(ageInput.text);
        heartRate = float.Parse(pulseInput.text);
        spo2 = float.Parse(spo2Input.text);
        height = float.Parse(heightInput.text);
        weight = float.Parse(weightInput.text);
        sleep = float.Parse(sleepInput.text);

        scene1.SetActive(false);
        scene2.SetActive(false);
        scene3.SetActive(true);

        if (sleepDisorders.isOn)
        {
            if (sleep > 9)
            {
                sleepText.text = "Please visit a sleep specialist, because you might have hypersomia!";
                sleep_time_Rating = 10;
            }
            if ((sleep < 9) && (sleep > 7))
            {
                sleepText.text = "You have a healthy sleep schedule!";
                sleep_time_Rating = 10;
            }
            if (sleep < 7)
            {
                sleepText.text = "You need to work on your sleep schedule";
                sleep_time_Rating = (8 - sleep) * 125 / 100;
            }
        }
        else
        {
            if (sleep > 9)
            {
                sleepText.text = ("Your sleep shoes no problems!");
                sleep_time_Rating = 10;
            }
            if ((sleep < 9) && (sleep > 7))
            {
                sleepText.text = "You have a healthy sleep schedule!";
                sleep_time_Rating = 10;
            }
            if (sleep < 7)
            {
                sleepText.text = "You need to work on your sleep schedule";
                sleep_time_Rating = (8 - sleep) * 125 / 100;
            }

        }
        if (age > 18)
        {
            if (heartRate > 90)
            {
                heartDataText.text = ("Heart rate too high. Consult a doctor. Do deep breaths, exercise well, and maintain a healthy diet reducing coffee consumption. Don't panic if you are stressed, everything will be fine.");
                float heartRateDev = (heartRate - 110) / 10;
                heartRateRating = 8 - heartRateDev;
            }
            else if (heartRate < 60)
            {
                heartDataText.text = ("Heart rate too low. Consult a doctor");
                float heartRateDev = (60 - heartRate) / 10;
                heartRateRating = 8 - heartRateDev;
            }
            else
            {
                heartDataText.text = ("Heart rate is healthy");
                float heartRateDev = (Mathf.Abs(heartRate - 85)) / 10;
                heartRateRating = 10 - heartRateDev;
            }
        }
        else
        {
            if (heartRate > 120)
            {
                heartDataText.text = ("Heart rate too high. Consult a doctor. Do deep breaths and maintain a healthy diet. Don't panic if you are stressed, everything will be fine.");
                float heartRateDev = (heartRate - 110) / 10;
                heartRateRating = 8 - heartRateDev;
            }
            else if (heartRate < 50)
            {
                heartDataText.text = ("Heart rate too low. Consult a doctor.");
                float heartRateDev = (50 - heartRate) / 10;
                heartRateRating = 8 - heartRateDev;
            }
            else
            {
                heartDataText.text = ("Heart rate is healthy");
                float heartRateDev = (Mathf.Abs(heartRate - 85)) / 10;
                heartRateRating = 10 - heartRateDev;
            }
        }

        heartRateRatingText.text = ("Heart Rate Rating : " + heartRateRating.ToString());

        SPO2Rating = (spo2 - 80) / 2;

        if (spo2 <= 94)
        {
            spo2Text.text = ("Your oxygen level is low. Consult a doctor. " + SPO2Rating + " is your SpO2 Rating.");
        }
        else
        {
            spo2Text.text = ("Your oxygen levels are healthy " + SPO2Rating + " is your SpO2 Rating.");
        }

        BMI = weight / (Mathf.Pow((height / 100), 2));
        bmiValueText.text = ("Your BMI is " + BMI + " kg/m²");

        if (age > 20)
        {
            if (BMI >= 25.0)
            {
                bmiPropertyText.text = ("Your BMI is higher than recommended levels");
                float BMIDev = BMI - 25;
                BMIRate = 8 - BMIDev;
            }
            if ((BMI < 24.9) && (BMI > 18.5))
            {
                bmiPropertyText.text = ("You have a healthy BMI");
                float BMIDev = Mathf.Abs(BMI - 21.7f);
                BMIRate = 10 - BMIDev;
            }
            if (BMI < 18.5)
            {
                bmiPropertyText.text = ("Your BMI is lower than recommended levels");
                float BMIDev = 18.5f - BMI;
                BMIRate = 8 - BMIDev;
            }
        }
        if (age <= 20)
        {
            if (age >= 2 && age <= 10)
            {
                if (BMI < 14)
                {
                    bmiPropertyText.text = ("Your BMI is lower than recommended levels");
                    float BMIDev = 14 - BMI;
                    BMIRate = 8 - BMIDev;
                }
                else if (BMI > 18)
                {
                    bmiPropertyText.text = ("Your BMI is higher than recommended levels");
                    float BMIDev = BMI - 18;
                    BMIRate = 8 - BMIDev;
                }
                else
                {
                    bmiPropertyText.text = ("You have a healthy BMI");
                    float BMIDev = Mathf.Abs(BMI - 16);
                    BMIRate = 10 - BMIDev;
                }
            }
            if (age >= 11 && age <= 14)
            {
                if (BMI < 14.5)
                {
                    bmiPropertyText.text = ("Your BMI is lower than recommended levels");
                    float BMIDev = 14.5f - BMI;
                    BMIRate = 8 - BMIDev;
                }
                else if (BMI > 22)
                {
                    bmiPropertyText.text = ("Your BMI is higher than recommended levels");
                    float BMIDev = BMI - 22;
                    BMIRate = 8 - BMIDev;
                }
                else
                {
                    bmiPropertyText.text = ("You have a healthy BMI");
                    float BMIDev = Mathf.Abs(BMI - 18.25f);
                    BMIRate = 10 - BMIDev;
                }
            }
            if (age > 14 && age <= 20)
            {
                if (BMI < 17)
                {
                    bmiPropertyText.text = ("Your BMI is lower than recommended levels");
                    float BMIDev = 17 - BMI;
                    BMIRate = 8 - BMIDev;
                }
                else if (BMI > 26)
                {
                    bmiPropertyText.text = ("Your BMI is higher than recommended levels");
                    float BMIDev = BMI - 26;
                    BMIRate = 8 - BMIDev;
                }
                else
                {
                    bmiPropertyText.text = ("You have a healthy BMI");
                    float BMIDev = Mathf.Abs(BMI - 21.5f);
                    BMIRate = 8 - BMIDev;
                }
            }
        }
        bmiRateText.text = ("Your BMI Rate is - " + BMIRate.ToString());
        healthRating.text = "Health Rate Index : " + (((SPO2Rating) + (heartRateRating) + (BMIRate) + (sleep_time_Rating)) / 4).ToString();
    }
    public void TestEyeSight()
    {
        Application.OpenURL("https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Snellen_chart.svg/800px-Snellen_chart.svg.png");
    }
}