namespace Laboratorium_2.Models
{
    public class Calculator
    {
        public Operators? Op { get; set; }
        public double? a { get; set; }
        public double? b { get; set; }

        public string Operator
        {
            get
            {
                switch (Op)
                {
                    case Operators.Add:
                        return "+";
                    case Operators.Sub:
                        return "-";
                    case Operators.Mul:
                        return "*";
                    case Operators.Div:
                        return "/";
                    default: return "";
                }
            }
            set { }
        }
        public bool IsValid()
        {
            return a != null && b != null && Op != null ;
        }

        public double Calculate()
        {
            switch (Op)
            {
                case Operators.Add:
                    return (double)(a + b);
                case Operators.Sub:
                    return (double)(a - b);
                case Operators.Mul:
                    return (double)(a * b);
                case Operators.Div:
                    return (double)(a / b);
                default: return double.NaN;
            }
        }
    }
}
