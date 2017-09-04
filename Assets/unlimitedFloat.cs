using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlimitedFloat {
    public ArrayList unlimitedFloats = new ArrayList();

    public void AddValue(unlimitedFloat otherUnlimitedFloats)
    {
        float repeater;
        if (unlimitedFloats.Count > otherUnlimitedFloats.unlimitedFloats.Count)
        {
            repeater = otherUnlimitedFloats.unlimitedFloats.Count;

        } else
        {
            float extraSlots = otherUnlimitedFloats.unlimitedFloats.Count - unlimitedFloats.Count;
            for (int i = 0; i < extraSlots; i++)
            {
                float EveryNextPosition = 000;
                unlimitedFloats.Add(EveryNextPosition);
            }
            repeater = otherUnlimitedFloats.unlimitedFloats.Count;
        }
        for (int i = 0; i < repeater; i++)
        {
            unlimitedFloats[i] = (float)unlimitedFloats[i] + (float)otherUnlimitedFloats.unlimitedFloats[i];
        }
        BalanceTheList();
    }

    public void AddValue(float addAmount, float Enumber)
    {
        while (addAmount > 999)
        {
            addAmount = addAmount / 1000;
            Enumber += 3;
        }

        if (unlimitedFloats.Count == 0)
        {
            float PositionZero = 000;
            unlimitedFloats.Add(PositionZero);
        }

        while (Enumber / 3 > unlimitedFloats.Count)
        {
            float EveryNextPosition = 000;
            unlimitedFloats.Add(EveryNextPosition);
        }

        int i = 0;
        while (Enumber / 3 - 1 > i)
        {
            i++;
        }

        while (Enumber > 3)
        {
            Enumber -= 3;
        }
        addAmount = addAmount * Mathf.Pow(10, Enumber);
        unlimitedFloats[i] = (float)unlimitedFloats[i] + addAmount;
        BalanceTheList();
    }

    public void RemoveValue(ArrayList otherUnlimitedFloats)
    {

    }

    public void RemoveValue(float addAmount, float Enumber)
    {


    }

    public unlimitedFloat MultipliValue(float addAmount, float Enumber)
    {
        float everyNextPosition = 000;
        while (addAmount >= 10)
        {
            addAmount = addAmount / 10;
            Enumber += 1;
        }

        unlimitedFloat unlimitedFloatsMultiplied = new unlimitedFloat();
        if (Enumber / 3 >= 1)
        {
            for (int i = 0; i < Mathf.Floor(Enumber / 3); i++)
            {
                unlimitedFloatsMultiplied.unlimitedFloats.Add(everyNextPosition);
            }
        }

        if (unlimitedFloats.Count != 0)
        {
            unlimitedFloatsMultiplied.unlimitedFloats.Add((float)unlimitedFloats[0] * Mathf.Pow(10, Enumber % 3));
            if (unlimitedFloats.Count >= 2)
            {
                for (int i = 1; i < unlimitedFloats.Count; i++)
                {
                    unlimitedFloatsMultiplied.unlimitedFloats.Add((float)unlimitedFloats[i]);
                }
            }
        }

        return unlimitedFloatsMultiplied;

    }

    public string GetValueSientific()
    {
        if (unlimitedFloats.Count == 0)
        {
            return "There never has been a value";
        }else
        {
            string Message = "";
            float ECounter = 0;
            for (int i = 0; i < unlimitedFloats.Count; i++)
            {
                if(i == 0)
                {
                    Message += unlimitedFloats[unlimitedFloats.Count - 1];
                    if(unlimitedFloats.Count-2 >= 0)
                    {
                    Message +=","+unlimitedFloats[unlimitedFloats.Count - 2];
                    }
                }else
                {
                    ECounter += 3;
                }
                
            }
            Message += "E+" + ECounter;
            return Message;
            
        }
    }

    public string GetValueFullLenght()
    {
        if (unlimitedFloats.Count == 0)
        {
            return "There never has been a value";
        }
        else
        {
            string Message = "";
            for (int i = 0; i < unlimitedFloats.Count; i++)
            {
                if (i == 0)
                {
                    Message += unlimitedFloats[unlimitedFloats.Count - 1];
                }
                else
                {
                    Message += "." + unlimitedFloats[unlimitedFloats.Count - 1 - i].ToString().PadLeft(3, '0');
                }
            }
            return Message;

        }

    }

    void BalanceAnyList(ArrayList BalanceableList)
    {
        for (int i = 0; i < BalanceableList.Count; i++)
        {
            if ((float)BalanceableList[i] > 999)
            {
                if (BalanceableList.Count > i + 1)
                {
                    float amountOverThreeZeros;
                    amountOverThreeZeros = Mathf.Floor((float)BalanceableList[i] / 1000);
                    BalanceableList[i + 1] = (float)BalanceableList[i + 1] + amountOverThreeZeros;
                    BalanceableList[i] = (float)BalanceableList[i] - (amountOverThreeZeros * 1000);
                }
                else
                {
                    while ((float)BalanceableList[i] > 999)
                    {
                        float amountOverThreeZeros;
                        amountOverThreeZeros = Mathf.Floor((float)BalanceableList[i] / 1000);
                        float EveryNextPosition = 000;
                        BalanceableList.Add(EveryNextPosition);
                        BalanceableList[i + 1] = (float)BalanceableList[i + 1] + amountOverThreeZeros;
                        BalanceableList[i] = (float)BalanceableList[i] - (amountOverThreeZeros * 1000);
                        i++;
                    }
                }
            }
        }
    }

    public void BalanceTheList()
    {
        for (int i = 0; i < unlimitedFloats.Count; i++)
        {
            if ((float)unlimitedFloats[i] > 999)
            {
                
                if (unlimitedFloats.Count > i + 1)
                {
                    float amountOverThreeZeros;
                    amountOverThreeZeros = Mathf.Floor((float)unlimitedFloats[i] / 1000);
                    unlimitedFloats[i + 1] = (float)unlimitedFloats[i + 1] + amountOverThreeZeros;
                    unlimitedFloats[i] = (float)unlimitedFloats[i] - (amountOverThreeZeros * 1000);
                }
                else
                {
                    while ((float)unlimitedFloats[i] > 999)
                    {
                        float amountOverThreeZeros;
                        amountOverThreeZeros = Mathf.Floor((float)unlimitedFloats[i] / 1000);
                        float EveryNextPosition = 000;
                        unlimitedFloats.Add(EveryNextPosition);
                        unlimitedFloats[i + 1] = (float)unlimitedFloats[i + 1] + amountOverThreeZeros;
                        unlimitedFloats[i] = (float)unlimitedFloats[i] - (amountOverThreeZeros * 1000);
                        i++;
                    }
                }
            }
        }
        for (int i = 0; i < unlimitedFloats.Count; i++)
        {
            unlimitedFloats[i] = Mathf.Round((float)unlimitedFloats[i]);
        }

        }

}
