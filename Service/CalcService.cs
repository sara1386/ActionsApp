using Entities;
namespace Service
{
    public class CalcService : ICalcService
    {
        public double calculate(CalcData calcData)
        {
           
            switch (calcData.Operator)
            {
                case "add":
                    return calcData.value1 + calcData.value2;
                case "subtract":
                    return calcData.value1 - calcData.value2;
                case "multiple":
                    return calcData.value1 * calcData.value2;
                case "divide":
                    return calcData.value1 / calcData.value2;

                default: throw new Exception("action not valid");
            }
        }


        public bool isValidAction(string op)
        {
            if (op != "add" && op != "subtract" && op != "multiple" && op != "divide")
            {
                return false;
            }
            return true;

        }
        public bool checkValidActionDivideByZero(CalcData calcData)
        {
            if (calcData.Operator == "divide" && calcData.value2 == 0)
                return false; 
            return true;
        }

        
    }
}