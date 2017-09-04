using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueTesting : MonoBehaviour {
    unlimitedFloat TestValue = new unlimitedFloat();
    unlimitedFloat TestValueMultiplied = new unlimitedFloat();
    public Text convertThisPlz;
    public Text convertThisAswellPlz;
    public float test;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ConvertitNow()
    {
        float f;
        float.TryParse(convertThisPlz.text, out f);
        float e;
        float.TryParse(convertThisAswellPlz.text, out e);
        test = f;
        TestValue.AddValue(f, e);
        Debug.Log(TestValue.GetValueFullLenght());
    }

    public void MultipliItPlz()
    {
        unlimitedFloat TestValueMultipliedtwo = TestValue.MultipliValue(1, 11);
        Debug.Log(TestValueMultipliedtwo.GetValueFullLenght());
        TestValueMultipliedtwo.BalanceTheList();
        Debug.Log(TestValueMultipliedtwo.GetValueFullLenght());
        TestValue.AddValue(TestValueMultipliedtwo);
        Debug.Log(TestValue.GetValueFullLenght());
    }
}
