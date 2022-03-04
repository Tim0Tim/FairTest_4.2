using System;
using System.Collections.Generic;
using System.Text;

namespace FairTaxPlan
{
    public class FairTax
    {
        private decimal housing;//to store housing tax
        private decimal food;//to store food tax
        private decimal clothing;//to store clothing tax
        private decimal transportation;//to store transportation tax
        private decimal education;//to store education tax
        private decimal healthCare;//to store healthcare tax
        private decimal vacations;//to store vacations tax
                                  //housing tax property
        public decimal HousingTax
        {
            get
            {
                return housing;
            }
            set
            {
                housing = value * 30 / 100;//setting vacations to 30 of the set amount.
            }
        }
        //food tax property
        public decimal FoodTax
        {
            get
            {
                return food;
            }
            set
            {
                food = value * 30 / 100;//setting vacations to 30 of the set amount.
            }
        }
        //clothing tax property
        public decimal ClothingTax
        {
            get
            {
                return clothing;
            }
            set
            {
                clothing = value * 30 / 100;//setting vacations to 30 of the set amount.
            }
        }
        //tranportation tax property
        public decimal TransporationTax
        {
            get
            {
                return transportation;
            }
            set
            {
                transportation = value * 30 / 100;//setting vacations to 30 of the set amount.
            }
        }
        //education tax property
        public decimal EducationTax
        {
            get
            {
                return education;
            }
            set
            {
                education = value * 30 / 100;//setting vacations to 30 of the set amount.
            }
        }
        //healthcare tax property
        public decimal HealthCareTax
        {
            get
            {
                return healthCare;
            }
            set
            {
                healthCare = value * 30 / 100;//setting vacations to 30 of the set amount.
            }
        }
        //vacations tax property.
        public decimal VacationsTax
        {
            get
            {
                return vacations;
            }
            set
            {
                vacations = value * 30 / 100;//setting vacations to 30 of the set amount.
            }
        }
    }
}
