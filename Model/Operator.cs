namespace Walfrido.DML.Automation.Model
{
    public class Operator
    {
        private string operatorValue;
        private Types.OPERATOR operatorEnum;
        public Types.OPERATOR Operador
        {
            get
            {
                return operatorEnum;
            }
            set
            {
                operatorEnum = value;
                operatorValue = Types.GetOperator(operatorEnum);
            }
        }

        public string OperatorValue
        {
            get
            {
                return operatorValue;
            }
        }

        public Operator(Types.OPERATOR operatorEnum)
        {
            Operador = operatorEnum;
            operatorValue = Types.GetOperator(operatorEnum);
        } 
    }
}
