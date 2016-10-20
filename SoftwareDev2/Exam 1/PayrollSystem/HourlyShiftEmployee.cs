//Nick Schuler
//Exam 1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class HourlyShiftEmployee : HourlyEmployee
{
    private int shift;
    
    public HourlyShiftEmployee(string first, string last, string ssn, decimal hourlyWage, decimal hoursWorked, int shift)
        : base(first, last, ssn, hourlyWage, hoursWorked)
    {
        Shift = shift;
    }

    public int Shift
    {
        get
        {
            return shift;
        }
        set
        {
            if (value >= 1 && value <= 3)
            {
                shift = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Shift must be between 1 and 3");
            }
        }
    }

    public override decimal Earnings()
    {
        if (shift == 1)
            return base.Earnings();
        else if (shift == 2)
            return base.Earnings() + 100;
        else
            return base.Earnings() + 200;
    }

    public override string ToString()
    {
        return string.Format("{0}\nShift Taken:{1}", base.ToString(), Shift);
    }
}
