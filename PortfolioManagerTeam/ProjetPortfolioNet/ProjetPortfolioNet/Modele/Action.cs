using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPortfolioNet.Modele
{
    class Action
    {
        #region Private Fields

        private string name; 
        private double price;

        #endregion Private Fields

        #region Public Constructors

        public Action(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        #endregion Public Constructors


        #region Public Methods

        public string getName()
        {
            return this.name;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setPrice(double p)
        {
            price = p;
        }

        #endregion Public Methods

    }
}
