using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class CarBuilder
    {
        string strColor;
        string strEngine;
        public float fTotalPrice=0;

        public float fEngine = 0;
        public float fColor = 0;

        public float fLaneAsist = 0;
        public float fRearView = 0;
        public float fLED = 0;
        public float fParkAsistant=0;
        public float fAppConnect = 0;
        public float fNavigationSystem = 0;


        float GetPrice(string strDef)
        {
            int iPos = strDef.LastIndexOf("#");
            string strPrice = strDef.Substring(iPos + 1);
            return Convert.ToSingle(strPrice);
        }
        public float price()             // Calculate the total price of a car
        {
            fTotalPrice = fEngine+fColor+ fLaneAsist + fRearView + fRearView + fLED + fParkAsistant + fAppConnect + fNavigationSystem;
            return (fTotalPrice);
        }

        public void SetColor(string strColorPar)
        {
            fColor = GetPrice(strColorPar);            
            price();
        }
        public void SetEngine(string strEnginePar)
        {
            fEngine = GetPrice(strEnginePar);
            price();
        }
        public void SetLaneAsist(string strPar)
        {
            fLaneAsist = GetPrice(strPar);
            price();
        }
        public void SetRearView(string strPar)
        {
            fRearView = GetPrice(strPar);
            price();
        }
        public void SetLED(string strPar)
        {
            fLED = GetPrice(strPar);
            price();
        }
        public void SetParkAssistant(string strPar)
        {
            fParkAsistant = GetPrice(strPar);
            price();
        }
        public void SetAppConnect(string strPar)
        {
            fAppConnect = GetPrice(strPar);
            price();
        }
        public void SetNavigationSystem(string strPar)
        {
            fNavigationSystem = GetPrice(strPar);
            price();
        }
    };
}
