

var sale = new SaleWithTax(15, 1.16m);
var message = sale.GetInfo();

Console.WriteLine(message);


class SaleWithTax : Sale
{

    public decimal Tax { get; set; }
    public SaleWithTax(decimal total, decimal tax) : base(total)
    {
        Tax = tax;
    }

    public override string GetInfo()
    {
        return "El total es " + Total + " y el impuesto es " + Tax;
    }


    // Sobrecarga
    public string GetInfo(string message)
    {
        return message;
    }


}


class Sale
{
    public decimal Total { get; set; }

    public Sale(decimal total)
    {
        Total = total;
    }

    public virtual string GetInfo()
    {
        return "El total es " + Total;
    }

}