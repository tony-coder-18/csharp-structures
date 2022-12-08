Clientes myClients = new Clientes("Luisa Camargo",12345,"cra 54","luisa@gmk.com",false);

Console.WriteLine(myClients);

Clientes myNewClients = myClients with { FullName = "Itala B" };

Console.WriteLine(myNewClients);
public struct Clientes
{
    public Clientes(string fullName, int phone, string address, string email, bool newClient)
    {
        FullName = fullName;
        Phone = phone;
        Address = address;
        Email = email;
        NewClient = newClient;
    }

    public string FullName { get; set; }
    public int Phone { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public bool NewClient { get; set; }


    public override string ToString() => $"{FullName}, {Phone}, {Address}, {Email}, {NewClient}";
}