using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1
{
    class Report
    {
        // getter and setter method to get and set Visit_Date
        public String Visit_Date { get; set; }
        // getter and setter method to get and set Total_Visitors
        public int Total_Visitors { get; set; }
        // getter and setter method to get and set Total_Income
        public double Total_Income { get; set; }

        // method to swap total earning values in ascending order using bubble sort algorithm
        public List<Report> earningAsc(List<Report> reports)
        {
            if (reports != null)
            {
                for (int i = 0; i < reports.Count - 1; i++)
                {
                    for (int j = i + 1; j < reports.Count; j++)
                    {
                        if (reports[i].Total_Income.CompareTo(reports[j].Total_Income) > 0)
                        {
                            Report a = reports[i];
                            reports[i] = reports[j];
                            reports[j] = a;
                        }
                    }
                }
                return reports;
            }
            return null;
        }
        // method to swap total earning values in descending order using bubble sort algorithm
        public List<Report> earningDesc(List<Report> reports)
        {
            if (reports != null)
            {
                for (int i = 0; i < reports.Count - 1; i++)
                {
                    for (int j = i + 1; j < reports.Count; j++)
                    {
                        if (reports[i].Total_Income.CompareTo(reports[j].Total_Income) < 0)
                        {
                            Report a = reports[i];
                            reports[i] = reports[j];
                            reports[j] = a;
                        }
                    }
                }
                return reports;
            }
            return null;
        }
        // method to swap total visitors values in descending order using bubble sort algorithm
        public List<Report> visitorDesc(List<Report> reports)
        {
            if (reports != null)
            {
                for (int i = 0; i < reports.Count - 1; i++)
                {
                    for (int j = i + 1; j < reports.Count; j++)
                    {
                        if (reports[i].Total_Visitors.CompareTo(reports[j].Total_Visitors) < 0)
                        {

                            Report a = reports[i];
                            reports[i] = reports[j];
                            reports[j] = a;
                        }
                    }
                }
                return reports;
            }
            return null;
        }
        // method to swap total visitors values in ascending order using bubble sort algorithm
        public List<Report> visitorAsc(List<Report> reports)
        {
            if (reports != null)
            {
                for (int i = 0; i < reports.Count - 1; i++)
                {
                    for (int j = i + 1; j < reports.Count; j++)
                    {
                        if (reports[i].Total_Visitors.CompareTo(reports[j].Total_Visitors) > 0)
                        {

                            Report a = reports[i];
                            reports[i] = reports[j];
                            reports[j] = a;

                        }
                    }
                }
                return reports;
            }
            return null;
        }

    }
}
