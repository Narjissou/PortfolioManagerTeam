using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPortfolioNet.Modele
{
    class Option
    {
        #region Private Fields

        private string name;
        private double strike;
        private double price;
        private double vol;
        private int maturity;

        #endregion Private Fields

        #region Public Constructors

        public Option(string name, double strike, double price, double vol, int maturity)
        {
            this.name = name;
            this.strike = strike;
            this.price = price;
            this.vol = vol;
            this.maturity = maturity;
        }

        #endregion Public Constructors

        public string getName()
        {
            return this.name;
        }

        public double getStrike()
        {
            return this.strike;
        }

        public double getVol()
        {
            return this.vol;
        }

        public double getMaturity()
        {
            return this.maturity;
        }
    }
}
