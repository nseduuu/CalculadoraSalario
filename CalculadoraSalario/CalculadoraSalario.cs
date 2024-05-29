namespace CalculadoraSalario
{
    public sealed class CalculadoraSalario
    {
        public double UltimoBruto;
        public double UltimoLiquido;

        public CalculadoraSalario() { }

        public double GetSalarioLiquido(double bruto)
        {
            double liquido = bruto - GetDescontoInss(bruto) - getDescontoIr(bruto);

            UltimoBruto = bruto;
            UltimoLiquido = liquido;

            return liquido;
        }

        // menos de 1000 -> 5%
        // 1000+ -> 10%
        public double GetDescontoInss(double bruto)
        {
            if(bruto < 0) 
            { 
                throw new Exception("Salário não pode ser menor que R$0,01");
            }
            return bruto < 1000 ? bruto * 0.05 : bruto * 0.10;
        }

        //menos de 1000 -> isento
        // entre 1000 e 3000 -> 10%
        // mais de 3000 -> 20%
        public double getDescontoIr(double bruto)
        {
            return bruto < 1000 ? 0 : bruto < 3000 ? bruto * 0.1 : bruto * 0.2;
        }
    }
}
