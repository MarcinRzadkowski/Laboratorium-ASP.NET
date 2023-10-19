namespace Laboratorium_2.Models
{
    public class Calculator
    {
        public Operators? Operator { get; set; }
        public double? a { get; set; }
        public double? b { get; set; }

        public String Op
        {
            get
            {
                switch (Operator)
                {
                    case Operators.Add:
                        return "+";
                    case Operators.Sub:
                        return "-";
                    case Operators.Mul:
                        return "*";
                    case Operators.Div:
                        return "/";
                    default:
                        return "";
                }
            }
        }

        public bool IsValid()
        {
            return Operator != null && a != null && b != null;
        }

        public double Calculate()
        {
            switch (Operator)
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
