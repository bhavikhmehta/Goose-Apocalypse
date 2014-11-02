using System;


class Resistor
{
    double tolerance; 
    double resistance;


    public Resistor (double resistance, double tolerance)
    {
        this.tolerance = tolerance;
        this.resistance = resistance;
    }  

    //cresistance is the current weapon of the player
    //optresistance is the resistor the use will potentionally pick up
    public void Change (double optresistance, double opttolerance)
    {

        Random value = new Random();
        int choose = value.Next(0,2);

        //parallel option
        if (choose == 0)
        {
            this.resistance = this.resistance - (1 / ((1 / this.resistance) + (1 / optresistance)));
        }

        //series option
        if (choose == 1)
        {
            this.resistance = this.resistance + optresistance;
        }

        if (opttolerance < this.tolerance)
        {
            this.tolerance = opttolerance;
        }

    }

    //swapping for a new resistor
    public void Swap (double resistance, double tolerance)
    {
        this.resistance = resistance;
        this.tolerance = tolerance;
    }

    public double Tolerance
    {
        get 
        {
            return this.tolerance;
        }
    }

    public double Resistance
    {
        get
        {
            return this.resistance;
        }
    }
}