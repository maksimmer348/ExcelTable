using System;

namespace ExcelTable
{
    public class ExcelReporter
    {
        
        public ExcelReport GetReport()
        {
            return new ExcelReport
            {
                Load = new OwerLoad
                {

                    Name = "OwerLoad ZZ",
                    Height = 50.14
                },
                OwerSpecifications = new[]
                {
                    new OwerLoadSpecifications
                        {SerialNumber = "FGGF20", Power = 50.1, Date = new DateTime(2021, 10, 2)},
                    new OwerLoadSpecifications {SerialNumber = "FGGF20", Power = 50.1, Date = new DateTime(2021, 10, 2)}
                }
            };
        }
    }
}