using Entities;

namespace Service
{
    public interface ICalcService
    {
        double calculate(CalcData calcData);
        public bool checkValidActionDivideByZero(CalcData calcData);

        public bool isValidAction(string op);
    }
}